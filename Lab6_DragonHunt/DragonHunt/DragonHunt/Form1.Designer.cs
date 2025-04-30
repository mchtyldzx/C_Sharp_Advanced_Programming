namespace DragonHunt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.warriorLabel = new System.Windows.Forms.Label();
            this.archerLabel = new System.Windows.Forms.Label();
            this.wizardLabel = new System.Windows.Forms.Label();
            this.dragonLabel = new System.Windows.Forms.Label();
            this.warriorHealthBar = new System.Windows.Forms.ProgressBar();
            this.archerHealthBar = new System.Windows.Forms.ProgressBar();
            this.wizardHealthBar = new System.Windows.Forms.ProgressBar();
            this.wizardManaBar = new System.Windows.Forms.ProgressBar();
            this.dragonHealthBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.potionLabel = new System.Windows.Forms.Label();
            this.warriorPotionButton = new System.Windows.Forms.Button();
            this.archerPotionButton = new System.Windows.Forms.Button();
            this.wizardPotionButton = new System.Windows.Forms.Button();
            this.fightButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.warriorExpTextBox = new System.Windows.Forms.TextBox();
            this.archerExpTextBox = new System.Windows.Forms.TextBox();
            this.wizardExpTextBox = new System.Windows.Forms.TextBox();
            this.warriorExpButton = new System.Windows.Forms.Button();
            this.archerExpButton = new System.Windows.Forms.Button();
            this.wizardExpButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Warrior Label
            this.warriorLabel.AutoSize = true;
            this.warriorLabel.Location = new System.Drawing.Point(12, 15);
            this.warriorLabel.Name = "warriorLabel";
            this.warriorLabel.Size = new System.Drawing.Size(100, 13);
            this.warriorLabel.TabIndex = 0;
            this.warriorLabel.Text = "Warrior";

            // Archer Label
            this.archerLabel.AutoSize = true;
            this.archerLabel.Location = new System.Drawing.Point(12, 65);
            this.archerLabel.Name = "archerLabel";
            this.archerLabel.Size = new System.Drawing.Size(100, 13);
            this.archerLabel.TabIndex = 1;
            this.archerLabel.Text = "Archer";

            // Wizard Label
            this.wizardLabel.AutoSize = true;
            this.wizardLabel.Location = new System.Drawing.Point(12, 115);
            this.wizardLabel.Name = "wizardLabel";
            this.wizardLabel.Size = new System.Drawing.Size(100, 13);
            this.wizardLabel.TabIndex = 2;
            this.wizardLabel.Text = "Wizard";

            // Dragon Label
            this.dragonLabel.AutoSize = true;
            this.dragonLabel.Location = new System.Drawing.Point(12, 165);
            this.dragonLabel.Name = "dragonLabel";
            this.dragonLabel.Size = new System.Drawing.Size(100, 13);
            this.dragonLabel.TabIndex = 3;
            this.dragonLabel.Text = "Dragon";

            // Health Bars
            this.warriorHealthBar.Location = new System.Drawing.Point(12, 30);
            this.warriorHealthBar.Name = "warriorHealthBar";
            this.warriorHealthBar.Size = new System.Drawing.Size(200, 23);
            this.warriorHealthBar.TabIndex = 4;

            this.archerHealthBar.Location = new System.Drawing.Point(12, 80);
            this.archerHealthBar.Name = "archerHealthBar";
            this.archerHealthBar.Size = new System.Drawing.Size(200, 23);
            this.archerHealthBar.TabIndex = 5;

            this.wizardHealthBar.Location = new System.Drawing.Point(12, 130);
            this.wizardHealthBar.Name = "wizardHealthBar";
            this.wizardHealthBar.Size = new System.Drawing.Size(200, 23);
            this.wizardHealthBar.TabIndex = 6;

            // Wizard Mana Bar
            this.wizardManaBar.Location = new System.Drawing.Point(12, 153);
            this.wizardManaBar.Name = "wizardManaBar";
            this.wizardManaBar.Size = new System.Drawing.Size(200, 5);
            this.wizardManaBar.TabIndex = 7;
            this.wizardManaBar.ForeColor = System.Drawing.Color.Blue;

            this.dragonHealthBar.Location = new System.Drawing.Point(12, 180);
            this.dragonHealthBar.Name = "dragonHealthBar";
            this.dragonHealthBar.Size = new System.Drawing.Size(200, 23);
            this.dragonHealthBar.TabIndex = 8;

            // Status Label
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 270);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(200, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "";

            // Potion Label
            this.potionLabel.AutoSize = true;
            this.potionLabel.Location = new System.Drawing.Point(12, 215);
            this.potionLabel.Name = "potionLabel";
            this.potionLabel.Size = new System.Drawing.Size(100, 13);
            this.potionLabel.TabIndex = 10;
            this.potionLabel.Text = "Healing Potions: 3";

            // Potion Buttons
            this.warriorPotionButton.Location = new System.Drawing.Point(218, 30);
            this.warriorPotionButton.Name = "warriorPotionButton";
            this.warriorPotionButton.Size = new System.Drawing.Size(75, 23);
            this.warriorPotionButton.TabIndex = 11;
            this.warriorPotionButton.Text = "Use Potion";
            this.warriorPotionButton.Click += new System.EventHandler(this.warriorPotionButton_Click);

            this.archerPotionButton.Location = new System.Drawing.Point(218, 80);
            this.archerPotionButton.Name = "archerPotionButton";
            this.archerPotionButton.Size = new System.Drawing.Size(75, 23);
            this.archerPotionButton.TabIndex = 12;
            this.archerPotionButton.Text = "Use Potion";
            this.archerPotionButton.Click += new System.EventHandler(this.archerPotionButton_Click);

            this.wizardPotionButton.Location = new System.Drawing.Point(218, 130);
            this.wizardPotionButton.Name = "wizardPotionButton";
            this.wizardPotionButton.Size = new System.Drawing.Size(75, 23);
            this.wizardPotionButton.TabIndex = 13;
            this.wizardPotionButton.Text = "Use Potion";
            this.wizardPotionButton.Click += new System.EventHandler(this.wizardPotionButton_Click);

            // Fight and Reset Buttons
            this.fightButton.Location = new System.Drawing.Point(12, 240);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(100, 23);
            this.fightButton.TabIndex = 14;
            this.fightButton.Text = "Fight!";
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);

            this.resetButton.Location = new System.Drawing.Point(118, 240);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 23);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);

            // Experience TextBoxes
            this.warriorExpTextBox.Location = new System.Drawing.Point(300, 30);
            this.warriorExpTextBox.Name = "warriorExpTextBox";
            this.warriorExpTextBox.Size = new System.Drawing.Size(100, 20);
            this.warriorExpTextBox.TabIndex = 16;

            this.archerExpTextBox.Location = new System.Drawing.Point(300, 80);
            this.archerExpTextBox.Name = "archerExpTextBox";
            this.archerExpTextBox.Size = new System.Drawing.Size(100, 20);
            this.archerExpTextBox.TabIndex = 17;

            this.wizardExpTextBox.Location = new System.Drawing.Point(300, 130);
            this.wizardExpTextBox.Name = "wizardExpTextBox";
            this.wizardExpTextBox.Size = new System.Drawing.Size(100, 20);
            this.wizardExpTextBox.TabIndex = 18;

            // Experience Buttons
            this.warriorExpButton.Location = new System.Drawing.Point(406, 30);
            this.warriorExpButton.Name = "warriorExpButton";
            this.warriorExpButton.Size = new System.Drawing.Size(75, 23);
            this.warriorExpButton.TabIndex = 19;
            this.warriorExpButton.Text = "Add EXP";
            this.warriorExpButton.Click += new System.EventHandler(this.warriorExpButton_Click);

            this.archerExpButton.Location = new System.Drawing.Point(406, 80);
            this.archerExpButton.Name = "archerExpButton";
            this.archerExpButton.Size = new System.Drawing.Size(75, 23);
            this.archerExpButton.TabIndex = 20;
            this.archerExpButton.Text = "Add EXP";
            this.archerExpButton.Click += new System.EventHandler(this.archerExpButton_Click);

            this.wizardExpButton.Location = new System.Drawing.Point(406, 130);
            this.wizardExpButton.Name = "wizardExpButton";
            this.wizardExpButton.Size = new System.Drawing.Size(75, 23);
            this.wizardExpButton.TabIndex = 21;
            this.wizardExpButton.Text = "Add EXP";
            this.wizardExpButton.Click += new System.EventHandler(this.wizardExpButton_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.warriorLabel,
                this.archerLabel,
                this.wizardLabel,
                this.dragonLabel,
                this.warriorHealthBar,
                this.archerHealthBar,
                this.wizardHealthBar,
                this.wizardManaBar,
                this.dragonHealthBar,
                this.statusLabel,
                this.potionLabel,
                this.warriorPotionButton,
                this.archerPotionButton,
                this.wizardPotionButton,
                this.fightButton,
                this.resetButton,
                this.warriorExpTextBox,
                this.archerExpTextBox,
                this.wizardExpTextBox,
                this.warriorExpButton,
                this.archerExpButton,
                this.wizardExpButton
            });
            this.Name = "Form1";
            this.Text = "Dragon Hunt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label warriorLabel;
        private System.Windows.Forms.Label archerLabel;
        private System.Windows.Forms.Label wizardLabel;
        private System.Windows.Forms.Label dragonLabel;
        private System.Windows.Forms.ProgressBar warriorHealthBar;
        private System.Windows.Forms.ProgressBar archerHealthBar;
        private System.Windows.Forms.ProgressBar wizardHealthBar;
        private System.Windows.Forms.ProgressBar wizardManaBar;
        private System.Windows.Forms.ProgressBar dragonHealthBar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label potionLabel;
        private System.Windows.Forms.Button warriorPotionButton;
        private System.Windows.Forms.Button archerPotionButton;
        private System.Windows.Forms.Button wizardPotionButton;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox warriorExpTextBox;
        private System.Windows.Forms.TextBox archerExpTextBox;
        private System.Windows.Forms.TextBox wizardExpTextBox;
        private System.Windows.Forms.Button warriorExpButton;
        private System.Windows.Forms.Button archerExpButton;
        private System.Windows.Forms.Button wizardExpButton;
    }
} 