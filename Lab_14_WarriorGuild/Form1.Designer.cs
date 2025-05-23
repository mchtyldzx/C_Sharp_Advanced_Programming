namespace WarriorGuild;

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

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        this.dataGridViewWarriors = new System.Windows.Forms.DataGridView();
        this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.groupBoxEditWarrior = new System.Windows.Forms.GroupBox();
        this.buttonReset = new System.Windows.Forms.Button();
        this.buttonRemove = new System.Windows.Forms.Button();
        this.buttonUpdate = new System.Windows.Forms.Button();
        this.buttonAdd = new System.Windows.Forms.Button();
        this.textBoxMonster = new System.Windows.Forms.TextBox();
        this.numericUpDownHP = new System.Windows.Forms.NumericUpDown();
        this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
        this.comboBoxGender = new System.Windows.Forms.ComboBox();
        this.textBoxName = new System.Windows.Forms.TextBox();
        this.labelMonster = new System.Windows.Forms.Label();
        this.labelHP = new System.Windows.Forms.Label();
        this.labelLevel = new System.Windows.Forms.Label();
        this.labelGender = new System.Windows.Forms.Label();
        this.labelName = new System.Windows.Forms.Label();
        this.comboBoxWarriors = new System.Windows.Forms.ComboBox();
        this.labelSelectWarrior = new System.Windows.Forms.Label();
        this.groupBoxSort = new System.Windows.Forms.GroupBox();
        this.buttonSort = new System.Windows.Forms.Button();
        this.radioButtonDescending = new System.Windows.Forms.RadioButton();
        this.radioButtonAscending = new System.Windows.Forms.RadioButton();
        this.comboBoxSortProperty = new System.Windows.Forms.ComboBox();
        this.labelSortProperty = new System.Windows.Forms.Label();
        
        // dataGridViewWarriors
        this.dataGridViewWarriors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewWarriors.Location = new System.Drawing.Point(12, 37);
        this.dataGridViewWarriors.Name = "dataGridViewWarriors";
        this.dataGridViewWarriors.Size = new System.Drawing.Size(776, 150);
        this.dataGridViewWarriors.TabIndex = 0;
        
        // mainMenuStrip
        this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
        this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        this.mainMenuStrip.Name = "mainMenuStrip";
        this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
        this.mainMenuStrip.TabIndex = 1;
        this.mainMenuStrip.Text = "menuStrip1";
        
        // fileToolStripMenuItem
        this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        this.fileToolStripMenuItem.Text = "File";
        
        // loadToolStripMenuItem
        this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
        this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
        this.loadToolStripMenuItem.Text = "Load";
        this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
        
        // saveToolStripMenuItem
        this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
        this.saveToolStripMenuItem.Text = "Save";
        this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
        
        // exitToolStripMenuItem
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
        this.exitToolStripMenuItem.Text = "Exit";
        this.exitToolStripMenuItem.Click += new System.EventHandler((sender, e) => Application.Exit());
        
        // labelSelectWarrior
        this.labelSelectWarrior.AutoSize = true;
        this.labelSelectWarrior.Location = new System.Drawing.Point(12, 200);
        this.labelSelectWarrior.Name = "labelSelectWarrior";
        this.labelSelectWarrior.Size = new System.Drawing.Size(82, 15);
        this.labelSelectWarrior.TabIndex = 2;
        this.labelSelectWarrior.Text = "Select Warrior:";
        
        // comboBoxWarriors
        this.comboBoxWarriors.FormattingEnabled = true;
        this.comboBoxWarriors.Location = new System.Drawing.Point(100, 197);
        this.comboBoxWarriors.Name = "comboBoxWarriors";
        this.comboBoxWarriors.Size = new System.Drawing.Size(200, 23);
        this.comboBoxWarriors.TabIndex = 3;
        
        // groupBoxEditWarrior
        this.groupBoxEditWarrior.Controls.Add(this.buttonReset);
        this.groupBoxEditWarrior.Controls.Add(this.buttonRemove);
        this.groupBoxEditWarrior.Controls.Add(this.buttonUpdate);
        this.groupBoxEditWarrior.Controls.Add(this.buttonAdd);
        this.groupBoxEditWarrior.Controls.Add(this.textBoxMonster);
        this.groupBoxEditWarrior.Controls.Add(this.numericUpDownHP);
        this.groupBoxEditWarrior.Controls.Add(this.numericUpDownLevel);
        this.groupBoxEditWarrior.Controls.Add(this.comboBoxGender);
        this.groupBoxEditWarrior.Controls.Add(this.textBoxName);
        this.groupBoxEditWarrior.Controls.Add(this.labelMonster);
        this.groupBoxEditWarrior.Controls.Add(this.labelHP);
        this.groupBoxEditWarrior.Controls.Add(this.labelLevel);
        this.groupBoxEditWarrior.Controls.Add(this.labelGender);
        this.groupBoxEditWarrior.Controls.Add(this.labelName);
        this.groupBoxEditWarrior.Location = new System.Drawing.Point(12, 230);
        this.groupBoxEditWarrior.Name = "groupBoxEditWarrior";
        this.groupBoxEditWarrior.Size = new System.Drawing.Size(450, 200);
        this.groupBoxEditWarrior.TabIndex = 4;
        this.groupBoxEditWarrior.TabStop = false;
        this.groupBoxEditWarrior.Text = "Edit Warrior";
        
        // labelName
        this.labelName.AutoSize = true;
        this.labelName.Location = new System.Drawing.Point(20, 30);
        this.labelName.Name = "labelName";
        this.labelName.Size = new System.Drawing.Size(42, 15);
        this.labelName.TabIndex = 0;
        this.labelName.Text = "Name:";
        
        // labelGender
        this.labelGender.AutoSize = true;
        this.labelGender.Location = new System.Drawing.Point(20, 60);
        this.labelGender.Name = "labelGender";
        this.labelGender.Size = new System.Drawing.Size(48, 15);
        this.labelGender.TabIndex = 1;
        this.labelGender.Text = "Gender:";
        
        // labelLevel
        this.labelLevel.AutoSize = true;
        this.labelLevel.Location = new System.Drawing.Point(20, 90);
        this.labelLevel.Name = "labelLevel";
        this.labelLevel.Size = new System.Drawing.Size(37, 15);
        this.labelLevel.TabIndex = 2;
        this.labelLevel.Text = "Level:";
        
        // labelHP
        this.labelHP.AutoSize = true;
        this.labelHP.Location = new System.Drawing.Point(20, 120);
        this.labelHP.Name = "labelHP";
        this.labelHP.Size = new System.Drawing.Size(26, 15);
        this.labelHP.TabIndex = 3;
        this.labelHP.Text = "HP:";
        
        // labelMonster
        this.labelMonster.AutoSize = true;
        this.labelMonster.Location = new System.Drawing.Point(20, 150);
        this.labelMonster.Name = "labelMonster";
        this.labelMonster.Size = new System.Drawing.Size(54, 15);
        this.labelMonster.TabIndex = 4;
        this.labelMonster.Text = "Monster:";
        
        // textBoxName
        this.textBoxName.Location = new System.Drawing.Point(80, 27);
        this.textBoxName.Name = "textBoxName";
        this.textBoxName.Size = new System.Drawing.Size(150, 23);
        this.textBoxName.TabIndex = 5;
        
        // comboBoxGender
        this.comboBoxGender.FormattingEnabled = true;
        this.comboBoxGender.Location = new System.Drawing.Point(80, 57);
        this.comboBoxGender.Name = "comboBoxGender";
        this.comboBoxGender.Size = new System.Drawing.Size(150, 23);
        this.comboBoxGender.TabIndex = 6;
        
        // numericUpDownLevel
        this.numericUpDownLevel.Location = new System.Drawing.Point(80, 87);
        this.numericUpDownLevel.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        this.numericUpDownLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.numericUpDownLevel.Name = "numericUpDownLevel";
        this.numericUpDownLevel.Size = new System.Drawing.Size(150, 23);
        this.numericUpDownLevel.TabIndex = 7;
        this.numericUpDownLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
        
        // numericUpDownHP
        this.numericUpDownHP.Location = new System.Drawing.Point(80, 117);
        this.numericUpDownHP.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        this.numericUpDownHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.numericUpDownHP.Name = "numericUpDownHP";
        this.numericUpDownHP.Size = new System.Drawing.Size(150, 23);
        this.numericUpDownHP.TabIndex = 8;
        this.numericUpDownHP.Value = new decimal(new int[] { 100, 0, 0, 0 });
        
        // textBoxMonster
        this.textBoxMonster.Location = new System.Drawing.Point(80, 147);
        this.textBoxMonster.Name = "textBoxMonster";
        this.textBoxMonster.Size = new System.Drawing.Size(150, 23);
        this.textBoxMonster.TabIndex = 9;
        
        // buttonAdd
        this.buttonAdd.Location = new System.Drawing.Point(250, 27);
        this.buttonAdd.Name = "buttonAdd";
        this.buttonAdd.Size = new System.Drawing.Size(75, 23);
        this.buttonAdd.TabIndex = 10;
        this.buttonAdd.Text = "Add";
        this.buttonAdd.UseVisualStyleBackColor = true;
        this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
        
        // buttonUpdate
        this.buttonUpdate.Location = new System.Drawing.Point(250, 57);
        this.buttonUpdate.Name = "buttonUpdate";
        this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
        this.buttonUpdate.TabIndex = 11;
        this.buttonUpdate.Text = "Update";
        this.buttonUpdate.UseVisualStyleBackColor = true;
        this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
        
        // buttonRemove
        this.buttonRemove.Location = new System.Drawing.Point(250, 87);
        this.buttonRemove.Name = "buttonRemove";
        this.buttonRemove.Size = new System.Drawing.Size(75, 23);
        this.buttonRemove.TabIndex = 12;
        this.buttonRemove.Text = "Remove";
        this.buttonRemove.UseVisualStyleBackColor = true;
        this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
        
        // buttonReset
        this.buttonReset.Location = new System.Drawing.Point(250, 117);
        this.buttonReset.Name = "buttonReset";
        this.buttonReset.Size = new System.Drawing.Size(75, 23);
        this.buttonReset.TabIndex = 13;
        this.buttonReset.Text = "Reset";
        this.buttonReset.UseVisualStyleBackColor = true;
        this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
        
        // groupBoxSort
        this.groupBoxSort.Controls.Add(this.buttonSort);
        this.groupBoxSort.Controls.Add(this.radioButtonDescending);
        this.groupBoxSort.Controls.Add(this.radioButtonAscending);
        this.groupBoxSort.Controls.Add(this.comboBoxSortProperty);
        this.groupBoxSort.Controls.Add(this.labelSortProperty);
        this.groupBoxSort.Location = new System.Drawing.Point(480, 230);
        this.groupBoxSort.Name = "groupBoxSort";
        this.groupBoxSort.Size = new System.Drawing.Size(300, 150);
        this.groupBoxSort.TabIndex = 5;
        this.groupBoxSort.TabStop = false;
        this.groupBoxSort.Text = "Sort";
        
        // labelSortProperty
        this.labelSortProperty.AutoSize = true;
        this.labelSortProperty.Location = new System.Drawing.Point(20, 30);
        this.labelSortProperty.Name = "labelSortProperty";
        this.labelSortProperty.Size = new System.Drawing.Size(79, 15);
        this.labelSortProperty.TabIndex = 0;
        this.labelSortProperty.Text = "Sort Property:";
        
        // comboBoxSortProperty
        this.comboBoxSortProperty.FormattingEnabled = true;
        this.comboBoxSortProperty.Location = new System.Drawing.Point(105, 27);
        this.comboBoxSortProperty.Name = "comboBoxSortProperty";
        this.comboBoxSortProperty.Size = new System.Drawing.Size(170, 23);
        this.comboBoxSortProperty.TabIndex = 1;
        
        // radioButtonAscending
        this.radioButtonAscending.AutoSize = true;
        this.radioButtonAscending.Checked = true;
        this.radioButtonAscending.Location = new System.Drawing.Point(20, 60);
        this.radioButtonAscending.Name = "radioButtonAscending";
        this.radioButtonAscending.Size = new System.Drawing.Size(82, 19);
        this.radioButtonAscending.TabIndex = 2;
        this.radioButtonAscending.TabStop = true;
        this.radioButtonAscending.Text = "Ascending";
        this.radioButtonAscending.UseVisualStyleBackColor = true;
        
        // radioButtonDescending
        this.radioButtonDescending.AutoSize = true;
        this.radioButtonDescending.Location = new System.Drawing.Point(20, 85);
        this.radioButtonDescending.Name = "radioButtonDescending";
        this.radioButtonDescending.Size = new System.Drawing.Size(87, 19);
        this.radioButtonDescending.TabIndex = 3;
        this.radioButtonDescending.Text = "Descending";
        this.radioButtonDescending.UseVisualStyleBackColor = true;
        
        // buttonSort
        this.buttonSort.Location = new System.Drawing.Point(200, 70);
        this.buttonSort.Name = "buttonSort";
        this.buttonSort.Size = new System.Drawing.Size(75, 23);
        this.buttonSort.TabIndex = 4;
        this.buttonSort.Text = "Sort";
        this.buttonSort.UseVisualStyleBackColor = true;
        this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
        
        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.groupBoxSort);
        this.Controls.Add(this.groupBoxEditWarrior);
        this.Controls.Add(this.comboBoxWarriors);
        this.Controls.Add(this.labelSelectWarrior);
        this.Controls.Add(this.dataGridViewWarriors);
        this.Controls.Add(this.mainMenuStrip);
        this.MainMenuStrip = this.mainMenuStrip;
        this.Name = "Form1";
        this.Text = "Warrior Guild Manager";
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarriors)).EndInit();
        this.mainMenuStrip.ResumeLayout(false);
        this.mainMenuStrip.PerformLayout();
        this.groupBoxEditWarrior.ResumeLayout(false);
        this.groupBoxEditWarrior.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHP)).EndInit();
        this.groupBoxSort.ResumeLayout(false);
        this.groupBoxSort.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewWarriors;
    private System.Windows.Forms.MenuStrip mainMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Label labelSelectWarrior;
    private System.Windows.Forms.ComboBox comboBoxWarriors;
    private System.Windows.Forms.GroupBox groupBoxEditWarrior;
    private System.Windows.Forms.Button buttonReset;
    private System.Windows.Forms.Button buttonRemove;
    private System.Windows.Forms.Button buttonUpdate;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.TextBox textBoxMonster;
    private System.Windows.Forms.NumericUpDown numericUpDownHP;
    private System.Windows.Forms.NumericUpDown numericUpDownLevel;
    private System.Windows.Forms.ComboBox comboBoxGender;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label labelMonster;
    private System.Windows.Forms.Label labelHP;
    private System.Windows.Forms.Label labelLevel;
    private System.Windows.Forms.Label labelGender;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.GroupBox groupBoxSort;
    private System.Windows.Forms.Button buttonSort;
    private System.Windows.Forms.RadioButton radioButtonDescending;
    private System.Windows.Forms.RadioButton radioButtonAscending;
    private System.Windows.Forms.ComboBox comboBoxSortProperty;
    private System.Windows.Forms.Label labelSortProperty;
}
