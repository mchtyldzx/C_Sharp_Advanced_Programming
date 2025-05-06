using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameTrackerLibrary;
using System.Linq;

namespace GameTrackerApp
{
    public partial class Form1 : Form
    {
        private readonly GameManager manager = new();

        public Form1()
        {
            InitializeComponent();
            InitializeGameTypes();
            manager.OnGameCompleted += Manager_OnGameCompleted;
        }

        private void InitializeGameTypes()
        {
            if (cmbGenre == null) return;
            
            cmbGenre.Items.Clear();
            cmbGenre.Items.Add(new RPGGame());
            cmbGenre.Items.Add(new FPSGame());
            cmbGenre.Items.Add(new StrategyGame());
            cmbGenre.DisplayMember = "TypeName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle == null || lblStatus == null || cmbGenre == null || 
                dtpStart == null || dtpEnd == null || numHours == null || 
                numRating == null)
            {
                MessageBox.Show("One or more controls are not initialized properly.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                lblStatus.Text = "Game title cannot be empty.";
                return;
            }

            if (numHours.Value < 0)
            {
                lblStatus.Text = "Hours played cannot be negative.";
                return;
            }

            // Create GameType based on selected or entered value
            GameType gameType;
            if (cmbGenre.SelectedItem is GameType selectedType)
            {
                gameType = selectedType;
            }
            else if (!string.IsNullOrWhiteSpace(cmbGenre.Text))
            {
                // Create a new custom game type with the entered text
                gameType = new CustomGameType(cmbGenre.Text);
            }
            else
            {
                lblStatus.Text = "Please enter or select a game type.";
                return;
            }

            var game = new Game
            {
                Title = txtTitle.Text,
                Type = gameType,
                StartDate = dtpStart.Value,
                EndDate = dtpEnd.Checked ? dtpEnd.Value : null,
                HoursPlayed = (int)numHours.Value,
                Rating = (double)numRating.Value
            };

            try
            {
                manager.AddGame(game);
                lblStatus.Text = "Game added successfully.";
                UpdateGrid();
                ClearInputs();
            }
            catch (DuplicateGameException ex)
            {
                lblStatus.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void ClearInputs()
        {
            if (txtTitle == null || cmbGenre == null || dtpStart == null || 
                dtpEnd == null || numHours == null || numRating == null) return;

            txtTitle.Clear();
            cmbGenre.SelectedIndex = -1;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Checked = false;
            numHours.Value = 0;
            numRating.Value = 0;
        }

        private void UpdateGrid()
        {
            if (dgvGames == null) return;

            dgvGames.DataSource = null;
            dgvGames.DataSource = manager.GetAllGames().Select(g => new {
                g.Title,
                Type = g.Type?.ToString() ?? "Unknown",
                StartDate = g.StartDate.ToString("dd.MM.yyyy"),
                EndDate = g.EndDate?.ToString("dd.MM.yyyy"),
                g.HoursPlayed,
                g.Rating,
                Status = g.EndDate.HasValue ? "Completed" : "In Progress"
            }).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "JSON Files|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                GameStorage.Save(manager.GetAllGames(), dialog.FileName);
                lblStatus.Text = "Games saved.";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "JSON Files|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var loadedGames = GameStorage.Load(dialog.FileName);

                foreach (var game in loadedGames)
                {
                    try { manager.AddGame(game); }
                    catch { continue; } // Skip duplicates
                }

                UpdateGrid();
                lblStatus.Text = "Games loaded.";
            }
        }

        private void Manager_OnGameCompleted(Game game)
        {
            MessageBox.Show($"You have completed '{game.Title}'!", "Game Completed ");
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            var games = manager.GetAllGames();
            var totalPlaytime = games.Sum(g => g.HoursPlayed);
            var avgRating = games.GetAverageRating();
            var mostPlayed = games.GetMostPlayedGames(1).FirstOrDefault();
            
            var message = $"Total Playtime: {totalPlaytime} hours\n" +
                    $"Average Rating: {avgRating:F1}\n" +
                    $"Most Played Game: {mostPlayed?.Title ?? "None"} ({mostPlayed?.HoursPlayed ?? 0} hours)";
            
            MessageBox.Show(message, "Playtime Statistics");
        }

        private void btnGameTypeStats_Click(object sender, EventArgs e)
        {
            var stats = manager.GetAllGames().GetGameTypeStatistics();
            var message = "Game Type Statistics:\n\n";
            
            foreach (var stat in stats)
            {
                message += $"{stat.Key.TypeName}: {stat.Value} games\n";
            }
            
            MessageBox.Show(message, "Game Type Statistics");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGames.SelectedRows.Count == 0)
            {
                lblStatus.Text = "Please select a game to delete.";
                return;
            }

            // Use the original list of games for deletion
            var selectedGame = manager.GetAllGames().FirstOrDefault(g => g.Title == (string)dgvGames.SelectedRows[0].Cells["Title"].Value);

            if (selectedGame != null)
            {
                manager.GetAllGames().Remove(selectedGame);
                UpdateGrid();
                lblStatus.Text = "Game deleted.";
            }
            else
            {
                lblStatus.Text = "Game not found.";
            }
        }

        private void btnTopRated_Click(object sender, EventArgs e)
        {
            var topRatedGames = manager.GetAllGames()
                .OrderByDescending(g => g.Rating)
                .Take(5)
                .Select(g => new {
                    g.Title,
                    Type = g.Type?.ToString() ?? "Unknown",
                    StartDate = g.StartDate.ToString("dd.MM.yyyy"),
                    EndDate = g.EndDate?.ToString("dd.MM.yyyy"),
                    g.HoursPlayed,
                    g.Rating
                })
                .ToList();

            dgvGames.DataSource = null;
            dgvGames.DataSource = topRatedGames;

            lblStatus.Text = $"Showing top {topRatedGames.Count} rated game(s).";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch == null || dgvGames == null || lblStatus == null) return;

            var searchText = txtSearch.Text?.ToLower() ?? string.Empty;
            var filteredGames = manager.GetAllGames()
                .Where(g => (g.Title?.ToLower().Contains(searchText) ?? false) ||
                           (g.Type?.ToString().ToLower().Contains(searchText) ?? false))
                .ToList();

            dgvGames.DataSource = null;
            dgvGames.DataSource = filteredGames;

            lblStatus.Text = $"Showing {filteredGames.Count} game(s) matching '{txtSearch.Text}'.";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateGrid();
            lblStatus.Text = "Showing all games.";
        }
    }
}
