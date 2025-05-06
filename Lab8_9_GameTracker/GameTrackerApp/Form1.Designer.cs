namespace GameTrackerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            cmbGenre = new ComboBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            numHours = new NumericUpDown();
            numRating = new NumericUpDown();
            btnAdd = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnStats = new Button();
            dgvGames = new DataGridView();
            lblStatus = new Label();
            btnGameTypeStats = new Button();
            btnDelete = new Button();
            btnTopRated = new Button();
            txtSearch = new TextBox();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(20, 10);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Game Title";
            txtTitle.Size = new Size(200, 23);
            txtTitle.TabIndex = 4;
            // 
            // cmbGenre
            // 
            cmbGenre.Items.AddRange(new object[] { "RPG", "FPS", "Adventure", "Strategy", "Simulation" });
            cmbGenre.Location = new Point(240, 10);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(150, 23);
            cmbGenre.TabIndex = 5;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(20, 50);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 6;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(240, 50);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowCheckBox = true;
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 7;
            // 
            // numHours
            // 
            numHours.Location = new Point(460, 50);
            numHours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numHours.Name = "numHours";
            numHours.Size = new Size(100, 23);
            numHours.TabIndex = 8;
            // 
            // numRating
            // 
            numRating.DecimalPlaces = 1;
            numRating.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numRating.Location = new Point(580, 50);
            numRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(100, 23);
            numRating.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Game";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(130, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(240, 180);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 30);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.Click += btnLoad_Click;
            // 
            // btnStats
            // 
            btnStats.Location = new Point(350, 180);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(100, 30);
            btnStats.TabIndex = 13;
            btnStats.Text = "Playtime Stats";
            btnStats.Click += btnStats_Click;
            // 
            // dgvGames
            // 
            dgvGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGames.Location = new Point(20, 260);
            dgvGames.Name = "dgvGames";
            dgvGames.Size = new Size(760, 200);
            dgvGames.TabIndex = 14;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 470);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Ready.";
            // 
            // btnGameTypeStats
            // 
            btnGameTypeStats.Location = new Point(460, 180);
            btnGameTypeStats.Name = "btnGameTypeStats";
            btnGameTypeStats.Size = new Size(100, 30);
            btnGameTypeStats.TabIndex = 0;
            btnGameTypeStats.Text = "Game Type Stats";
            btnGameTypeStats.Click += btnGameTypeStats_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(580, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Game";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnTopRated
            // 
            btnTopRated.Location = new Point(20, 220);
            btnTopRated.Name = "btnTopRated";
            btnTopRated.Size = new Size(150, 30);
            btnTopRated.TabIndex = 2;
            btnTopRated.Text = "Top Rated Games";
            btnTopRated.Click += btnTopRated_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(180, 220);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Title, Type";
            txtSearch.Size = new Size(300, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(486, 215);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(150, 30);
            btnShowAll.TabIndex = 16;
            btnShowAll.Text = "Show All Games";
            btnShowAll.Click += btnShowAll_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(btnGameTypeStats);
            Controls.Add(btnDelete);
            Controls.Add(btnTopRated);
            Controls.Add(txtSearch);
            Controls.Add(txtTitle);
            Controls.Add(cmbGenre);
            Controls.Add(dtpStart);
            Controls.Add(dtpEnd);
            Controls.Add(numHours);
            Controls.Add(numRating);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnStats);
            Controls.Add(dgvGames);
            Controls.Add(lblStatus);
            Controls.Add(btnShowAll);
            Name = "Form1";
            Text = "Game Tracker";
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTitle;
        private ComboBox cmbGenre;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private NumericUpDown numHours;
        private NumericUpDown numRating;
        private Button btnAdd;
        private Button btnSave;
        private Button btnLoad;
        private Button btnStats;
        private Button btnDelete;
        private Button btnTopRated;
        private TextBox txtSearch;
        private DataGridView dgvGames;
        private Label lblStatus;
        private Button btnShowAll;
        private Button btnGameTypeStats;
    }
}
