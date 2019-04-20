namespace Pet_Master
{
    partial class FormNewPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPet));
            this.pictureBoxNewPet = new System.Windows.Forms.PictureBox();
            this.btnCreateLeft = new System.Windows.Forms.Button();
            this.btnCreateRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNewPet
            // 
            this.pictureBoxNewPet.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNewPet.Image")));
            this.pictureBoxNewPet.Location = new System.Drawing.Point(116, 12);
            this.pictureBoxNewPet.Name = "pictureBoxNewPet";
            this.pictureBoxNewPet.Size = new System.Drawing.Size(202, 146);
            this.pictureBoxNewPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNewPet.TabIndex = 0;
            this.pictureBoxNewPet.TabStop = false;
            // 
            // btnCreateLeft
            // 
            this.btnCreateLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateLeft.Location = new System.Drawing.Point(43, 68);
            this.btnCreateLeft.Name = "btnCreateLeft";
            this.btnCreateLeft.Size = new System.Drawing.Size(22, 23);
            this.btnCreateLeft.TabIndex = 1;
            this.btnCreateLeft.Text = "<";
            this.btnCreateLeft.UseVisualStyleBackColor = true;
            // 
            // btnCreateRight
            // 
            this.btnCreateRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateRight.Location = new System.Drawing.Point(381, 68);
            this.btnCreateRight.Name = "btnCreateRight";
            this.btnCreateRight.Size = new System.Drawing.Size(22, 23);
            this.btnCreateRight.TabIndex = 2;
            this.btnCreateRight.Text = ">";
            this.btnCreateRight.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FormNewPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(465, 374);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateRight);
            this.Controls.Add(this.btnCreateLeft);
            this.Controls.Add(this.pictureBoxNewPet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormNewPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewPet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNewPet;
        private System.Windows.Forms.Button btnCreateLeft;
        private System.Windows.Forms.Button btnCreateRight;
        private System.Windows.Forms.Label label1;
    }
}