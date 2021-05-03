
namespace DifficultySettings
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectDifficultyText = new System.Windows.Forms.Label();
            this.heroText = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.dialogueText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectDifficultyText
            // 
            this.selectDifficultyText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDifficultyText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectDifficultyText.Location = new System.Drawing.Point(51, 124);
            this.selectDifficultyText.Name = "selectDifficultyText";
            this.selectDifficultyText.Size = new System.Drawing.Size(217, 24);
            this.selectDifficultyText.TabIndex = 1;
            this.selectDifficultyText.Text = "Select Difficulty:";
            this.selectDifficultyText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // heroText
            // 
            this.heroText.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.heroText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.heroText.Location = new System.Drawing.Point(51, 26);
            this.heroText.Name = "heroText";
            this.heroText.Size = new System.Drawing.Size(217, 24);
            this.heroText.TabIndex = 2;
            this.heroText.Text = "Hero\'s Name:";
            this.heroText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(51, 69);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(217, 20);
            this.nameBox.TabIndex = 3;
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.easyButton.FlatAppearance.BorderSize = 2;
            this.easyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.easyButton.Location = new System.Drawing.Point(85, 163);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(144, 34);
            this.easyButton.TabIndex = 4;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.mediumButton.FlatAppearance.BorderSize = 2;
            this.mediumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediumButton.Location = new System.Drawing.Point(85, 203);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(144, 34);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.hardButton.FlatAppearance.BorderSize = 2;
            this.hardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hardButton.Location = new System.Drawing.Point(85, 243);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(144, 34);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.beginButton.FlatAppearance.BorderSize = 2;
            this.beginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.beginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.beginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.beginButton.Location = new System.Drawing.Point(85, 312);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(144, 34);
            this.beginButton.TabIndex = 6;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // dialogueText
            // 
            this.dialogueText.Font = new System.Drawing.Font("Arial", 10F);
            this.dialogueText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dialogueText.Location = new System.Drawing.Point(12, 365);
            this.dialogueText.Name = "dialogueText";
            this.dialogueText.Size = new System.Drawing.Size(297, 76);
            this.dialogueText.TabIndex = 7;
            this.dialogueText.Text = "Welcome Hero! A hero of casual fun picks the easy path!";
            this.dialogueText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.dialogueText);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.heroText);
            this.Controls.Add(this.selectDifficultyText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hero Conquest IV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectDifficultyText;
        private System.Windows.Forms.Label heroText;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label dialogueText;
    }
}

