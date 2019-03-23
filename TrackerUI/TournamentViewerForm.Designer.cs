namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundLable = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchUpListbox = new System.Windows.Forms.ListBox();
            this.teamoneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabe = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLable = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.Gainsboro;
            this.header.Location = new System.Drawing.Point(24, 33);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(165, 40);
            this.header.TabIndex = 0;
            this.header.Text = "Tounament:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(185, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "<none>";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundLable
            // 
            this.roundLable.AutoSize = true;
            this.roundLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.roundLable.Location = new System.Drawing.Point(24, 98);
            this.roundLable.Name = "roundLable";
            this.roundLable.Size = new System.Drawing.Size(94, 37);
            this.roundLable.TabIndex = 2;
            this.roundLable.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(124, 101);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(189, 38);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(124, 154);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(189, 36);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchUpListbox
            // 
            this.matchUpListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchUpListbox.FormattingEnabled = true;
            this.matchUpListbox.ItemHeight = 30;
            this.matchUpListbox.Location = new System.Drawing.Point(31, 228);
            this.matchUpListbox.Name = "matchUpListbox";
            this.matchUpListbox.Size = new System.Drawing.Size(282, 272);
            this.matchUpListbox.TabIndex = 5;
            // 
            // teamoneName
            // 
            this.teamoneName.AutoSize = true;
            this.teamoneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamoneName.ForeColor = System.Drawing.Color.Gainsboro;
            this.teamoneName.Location = new System.Drawing.Point(384, 226);
            this.teamoneName.Name = "teamoneName";
            this.teamoneName.Size = new System.Drawing.Size(167, 37);
            this.teamoneName.TabIndex = 6;
            this.teamoneName.Text = "<Team one>";
            // 
            // teamOneScoreLabe
            // 
            this.teamOneScoreLabe.AutoSize = true;
            this.teamOneScoreLabe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreLabe.ForeColor = System.Drawing.Color.Gainsboro;
            this.teamOneScoreLabe.Location = new System.Drawing.Point(384, 277);
            this.teamOneScoreLabe.Name = "teamOneScoreLabe";
            this.teamOneScoreLabe.Size = new System.Drawing.Size(82, 37);
            this.teamOneScoreLabe.TabIndex = 7;
            this.teamOneScoreLabe.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(472, 279);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(472, 450);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(100, 35);
            this.teamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScoreLable
            // 
            this.TeamTwoScoreLable.AutoSize = true;
            this.TeamTwoScoreLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.TeamTwoScoreLable.Location = new System.Drawing.Point(384, 447);
            this.TeamTwoScoreLable.Name = "TeamTwoScoreLable";
            this.TeamTwoScoreLable.Size = new System.Drawing.Size(82, 37);
            this.TeamTwoScoreLable.TabIndex = 10;
            this.TeamTwoScoreLable.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoName.ForeColor = System.Drawing.Color.Gainsboro;
            this.teamTwoName.Location = new System.Drawing.Point(384, 394);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(167, 37);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<Team two>";
            this.teamTwoName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.versusLabel.Location = new System.Drawing.Point(453, 341);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(53, 30);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ScoreButton.Location = new System.Drawing.Point(598, 341);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(91, 44);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(738, 544);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScoreLable);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScoreLabe);
            this.Controls.Add(this.teamoneName);
            this.Controls.Add(this.matchUpListbox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournamet Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roundLable;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchUpListbox;
        private System.Windows.Forms.Label teamoneName;
        private System.Windows.Forms.Label teamOneScoreLabe;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label TeamTwoScoreLable;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

