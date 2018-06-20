namespace BasicGameTemplate
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.menuTitle = new System.Windows.Forms.Label();
            this.scoresButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.Location = new System.Drawing.Point(86, 206);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 39);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playButton.Location = new System.Drawing.Point(86, 93);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(120, 39);
            this.playButton.TabIndex = 1;
            this.playButton.Tag = "GameScreen";
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // menuTitle
            // 
            this.menuTitle.BackColor = System.Drawing.Color.Transparent;
            this.menuTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuTitle.Location = new System.Drawing.Point(90, 34);
            this.menuTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(116, 33);
            this.menuTitle.TabIndex = 11;
            this.menuTitle.Text = "Main Menu";
            this.menuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoresButton
            // 
            this.scoresButton.BackColor = System.Drawing.Color.White;
            this.scoresButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scoresButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.scoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoresButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scoresButton.Location = new System.Drawing.Point(86, 148);
            this.scoresButton.Margin = new System.Windows.Forms.Padding(2);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(120, 39);
            this.scoresButton.TabIndex = 2;
            this.scoresButton.Text = "High Scores";
            this.scoresButton.UseVisualStyleBackColor = false;
            this.scoresButton.Click += new System.EventHandler(this.scoresButton_Click);
            this.scoresButton.Enter += new System.EventHandler(this.button_Enter);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::BasicGameTemplate.Properties.Resources.Day_background;
            this.Controls.Add(this.scoresButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.menuTitle);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(294, 264);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Button scoresButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
