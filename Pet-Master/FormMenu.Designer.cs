namespace Pet_Master
{
    partial class FormMenu
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
            this.labelLogoMenu = new System.Windows.Forms.Label();
            this.labelNewGameMenu = new System.Windows.Forms.Label();
            this.labelLoadGameMenu = new System.Windows.Forms.Label();
            this.labelQuitGameMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogoMenu
            // 
            this.labelLogoMenu.AutoSize = true;
            this.labelLogoMenu.Font = new System.Drawing.Font("Segoe Print", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogoMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelLogoMenu.Location = new System.Drawing.Point(12, 9);
            this.labelLogoMenu.Name = "labelLogoMenu";
            this.labelLogoMenu.Size = new System.Drawing.Size(220, 62);
            this.labelLogoMenu.TabIndex = 2;
            this.labelLogoMenu.Text = "Pet Master";
            // 
            // labelNewGameMenu
            // 
            this.labelNewGameMenu.AutoSize = true;
            this.labelNewGameMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNewGameMenu.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewGameMenu.Location = new System.Drawing.Point(68, 81);
            this.labelNewGameMenu.Name = "labelNewGameMenu";
            this.labelNewGameMenu.Size = new System.Drawing.Size(106, 23);
            this.labelNewGameMenu.TabIndex = 3;
            this.labelNewGameMenu.Text = "New Game";
            this.labelNewGameMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLoadGameMenu
            // 
            this.labelLoadGameMenu.AutoSize = true;
            this.labelLoadGameMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLoadGameMenu.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadGameMenu.Location = new System.Drawing.Point(67, 115);
            this.labelLoadGameMenu.Name = "labelLoadGameMenu";
            this.labelLoadGameMenu.Size = new System.Drawing.Size(109, 23);
            this.labelLoadGameMenu.TabIndex = 4;
            this.labelLoadGameMenu.Text = "Load Game";
            this.labelLoadGameMenu.Click += new System.EventHandler(this.labelLoadGameMenu_Click);
            // 
            // labelQuitGameMenu
            // 
            this.labelQuitGameMenu.AutoSize = true;
            this.labelQuitGameMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelQuitGameMenu.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuitGameMenu.Location = new System.Drawing.Point(97, 149);
            this.labelQuitGameMenu.Name = "labelQuitGameMenu";
            this.labelQuitGameMenu.Size = new System.Drawing.Size(49, 23);
            this.labelQuitGameMenu.TabIndex = 5;
            this.labelQuitGameMenu.Text = "Quit";
            this.labelQuitGameMenu.Click += new System.EventHandler(this.labelQuitGameMenu_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(252, 203);
            this.ControlBox = false;
            this.Controls.Add(this.labelQuitGameMenu);
            this.Controls.Add(this.labelLoadGameMenu);
            this.Controls.Add(this.labelNewGameMenu);
            this.Controls.Add(this.labelLogoMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogoMenu;
        private System.Windows.Forms.Label labelNewGameMenu;
        private System.Windows.Forms.Label labelLoadGameMenu;
        private System.Windows.Forms.Label labelQuitGameMenu;
    }
}

