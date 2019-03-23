namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.header = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLable = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamlabel = new System.Windows.Forms.Label();
            this.CreatNewTeamlink = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayerlabel = new System.Windows.Forms.Label();
            this.deleteSelectedplayersbutton = new System.Windows.Forms.Button();
            this.deleteSelectedprizebutton = new System.Windows.Forms.Button();
            this.prizeslabl = new System.Windows.Forms.Label();
            this.prizesListbox = new System.Windows.Forms.ListBox();
            this.tournamentPlayesListBox = new System.Windows.Forms.ListBox();
            this.CreatetournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.Gainsboro;
            this.header.Location = new System.Drawing.Point(24, 22);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(242, 40);
            this.header.TabIndex = 1;
            this.header.Text = "CreareTounament";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.tournamentNameLabel.Location = new System.Drawing.Point(24, 91);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.tournamentNameLabel.TabIndex = 3;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(31, 131);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(289, 35);
            this.tournamentNameValue.TabIndex = 9;
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(160, 206);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(100, 35);
            this.EntryFeeValue.TabIndex = 11;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLable
            // 
            this.EntryFeeLable.AutoSize = true;
            this.EntryFeeLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.EntryFeeLable.Location = new System.Drawing.Point(30, 203);
            this.EntryFeeLable.Name = "EntryFeeLable";
            this.EntryFeeLable.Size = new System.Drawing.Size(125, 37);
            this.EntryFeeLable.TabIndex = 10;
            this.EntryFeeLable.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(31, 315);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(289, 38);
            this.SelectTeamDropDown.TabIndex = 13;
            // 
            // SelectTeamlabel
            // 
            this.SelectTeamlabel.AutoSize = true;
            this.SelectTeamlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SelectTeamlabel.Location = new System.Drawing.Point(30, 275);
            this.SelectTeamlabel.Name = "SelectTeamlabel";
            this.SelectTeamlabel.Size = new System.Drawing.Size(156, 37);
            this.SelectTeamlabel.TabIndex = 12;
            this.SelectTeamlabel.Text = "Select Team";
            // 
            // CreatNewTeamlink
            // 
            this.CreatNewTeamlink.AutoSize = true;
            this.CreatNewTeamlink.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatNewTeamlink.LinkColor = System.Drawing.Color.Black;
            this.CreatNewTeamlink.Location = new System.Drawing.Point(223, 287);
            this.CreatNewTeamlink.Name = "CreatNewTeamlink";
            this.CreatNewTeamlink.Size = new System.Drawing.Size(97, 25);
            this.CreatNewTeamlink.TabIndex = 14;
            this.CreatNewTeamlink.TabStop = true;
            this.CreatNewTeamlink.Text = "Creat new";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddTeamButton.Location = new System.Drawing.Point(86, 380);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(180, 42);
            this.AddTeamButton.TabIndex = 15;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CreatePrizeButton.Location = new System.Drawing.Point(86, 437);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(180, 41);
            this.CreatePrizeButton.TabIndex = 16;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayerlabel
            // 
            this.tournamentPlayerlabel.AutoSize = true;
            this.tournamentPlayerlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayerlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.tournamentPlayerlabel.Location = new System.Drawing.Point(390, 91);
            this.tournamentPlayerlabel.Name = "tournamentPlayerlabel";
            this.tournamentPlayerlabel.Size = new System.Drawing.Size(198, 37);
            this.tournamentPlayerlabel.TabIndex = 18;
            this.tournamentPlayerlabel.Text = "Teams / Players";
            // 
            // deleteSelectedplayersbutton
            // 
            this.deleteSelectedplayersbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedplayersbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedplayersbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.deleteSelectedplayersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedplayersbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedplayersbutton.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteSelectedplayersbutton.Location = new System.Drawing.Point(697, 163);
            this.deleteSelectedplayersbutton.Name = "deleteSelectedplayersbutton";
            this.deleteSelectedplayersbutton.Size = new System.Drawing.Size(131, 78);
            this.deleteSelectedplayersbutton.TabIndex = 19;
            this.deleteSelectedplayersbutton.Text = "Delete  selected";
            this.deleteSelectedplayersbutton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedprizebutton
            // 
            this.deleteSelectedprizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedprizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedprizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.deleteSelectedprizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedprizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedprizebutton.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteSelectedprizebutton.Location = new System.Drawing.Point(697, 391);
            this.deleteSelectedprizebutton.Name = "deleteSelectedprizebutton";
            this.deleteSelectedprizebutton.Size = new System.Drawing.Size(131, 78);
            this.deleteSelectedprizebutton.TabIndex = 22;
            this.deleteSelectedprizebutton.Text = "Delete  Selected";
            this.deleteSelectedprizebutton.UseVisualStyleBackColor = true;
            // 
            // prizeslabl
            // 
            this.prizeslabl.AutoSize = true;
            this.prizeslabl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeslabl.ForeColor = System.Drawing.Color.Gainsboro;
            this.prizeslabl.Location = new System.Drawing.Point(390, 302);
            this.prizeslabl.Name = "prizeslabl";
            this.prizeslabl.Size = new System.Drawing.Size(198, 37);
            this.prizeslabl.TabIndex = 21;
            this.prizeslabl.Text = "Teams / Players";
            // 
            // prizesListbox
            // 
            this.prizesListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListbox.FormattingEnabled = true;
            this.prizesListbox.ItemHeight = 30;
            this.prizesListbox.Location = new System.Drawing.Point(397, 342);
            this.prizesListbox.Name = "prizesListbox";
            this.prizesListbox.Size = new System.Drawing.Size(282, 152);
            this.prizesListbox.TabIndex = 20;
            // 
            // tournamentPlayesListBox
            // 
            this.tournamentPlayesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayesListBox.FormattingEnabled = true;
            this.tournamentPlayesListBox.ItemHeight = 30;
            this.tournamentPlayesListBox.Location = new System.Drawing.Point(397, 131);
            this.tournamentPlayesListBox.Name = "tournamentPlayesListBox";
            this.tournamentPlayesListBox.Size = new System.Drawing.Size(282, 152);
            this.tournamentPlayesListBox.TabIndex = 23;
            // 
            // CreatetournamentButton
            // 
            this.CreatetournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatetournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatetournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CreatetournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatetournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatetournamentButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CreatetournamentButton.Location = new System.Drawing.Point(264, 526);
            this.CreatetournamentButton.Name = "CreatetournamentButton";
            this.CreatetournamentButton.Size = new System.Drawing.Size(324, 41);
            this.CreatetournamentButton.TabIndex = 24;
            this.CreatetournamentButton.Text = "Create Tournament";
            this.CreatetournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.CreatetournamentButton);
            this.Controls.Add(this.tournamentPlayesListBox);
            this.Controls.Add(this.deleteSelectedprizebutton);
            this.Controls.Add(this.prizeslabl);
            this.Controls.Add(this.prizesListbox);
            this.Controls.Add(this.deleteSelectedplayersbutton);
            this.Controls.Add(this.tournamentPlayerlabel);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreatNewTeamlink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamlabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLable);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label EntryFeeLable;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamlabel;
        private System.Windows.Forms.LinkLabel CreatNewTeamlink;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.Label tournamentPlayerlabel;
        private System.Windows.Forms.Button deleteSelectedplayersbutton;
        private System.Windows.Forms.Button deleteSelectedprizebutton;
        private System.Windows.Forms.Label prizeslabl;
        private System.Windows.Forms.ListBox prizesListbox;
        private System.Windows.Forms.ListBox tournamentPlayesListBox;
        private System.Windows.Forms.Button CreatetournamentButton;
    }
}