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
            this.labelNewPet = new System.Windows.Forms.Label();
            this.labelCreate1 = new System.Windows.Forms.Label();
            this.labelCreate2 = new System.Windows.Forms.Label();
            this.labelCreate3 = new System.Windows.Forms.Label();
            this.labelCreateHlad = new System.Windows.Forms.Label();
            this.labelCreateHygiena = new System.Windows.Forms.Label();
            this.labelCreateHravost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCreateSpanek = new System.Windows.Forms.Label();
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
            this.btnCreateRight.Click += new System.EventHandler(this.BtnCreateRight_Click);
            // 
            // labelNewPet
            // 
            this.labelNewPet.AutoSize = true;
            this.labelNewPet.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNewPet.Location = new System.Drawing.Point(156, 177);
            this.labelNewPet.Name = "labelNewPet";
            this.labelNewPet.Size = new System.Drawing.Size(131, 23);
            this.labelNewPet.TabIndex = 3;
            this.labelNewPet.Text = "NewPetName";
            // 
            // labelCreate1
            // 
            this.labelCreate1.AutoSize = true;
            this.labelCreate1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreate1.Location = new System.Drawing.Point(12, 228);
            this.labelCreate1.Name = "labelCreate1";
            this.labelCreate1.Size = new System.Drawing.Size(39, 20);
            this.labelCreate1.TabIndex = 4;
            this.labelCreate1.Text = "Hlad";
            // 
            // labelCreate2
            // 
            this.labelCreate2.AutoSize = true;
            this.labelCreate2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreate2.Location = new System.Drawing.Point(12, 260);
            this.labelCreate2.Name = "labelCreate2";
            this.labelCreate2.Size = new System.Drawing.Size(61, 20);
            this.labelCreate2.TabIndex = 5;
            this.labelCreate2.Text = "Hygiena";
            // 
            // labelCreate3
            // 
            this.labelCreate3.AutoSize = true;
            this.labelCreate3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreate3.Location = new System.Drawing.Point(12, 293);
            this.labelCreate3.Name = "labelCreate3";
            this.labelCreate3.Size = new System.Drawing.Size(66, 20);
            this.labelCreate3.TabIndex = 6;
            this.labelCreate3.Text = "Hravost";
            // 
            // labelCreateHlad
            // 
            this.labelCreateHlad.AutoSize = true;
            this.labelCreateHlad.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateHlad.Location = new System.Drawing.Point(112, 228);
            this.labelCreateHlad.Name = "labelCreateHlad";
            this.labelCreateHlad.Size = new System.Drawing.Size(43, 20);
            this.labelCreateHlad.TabIndex = 7;
            this.labelCreateHlad.Text = "Hlad";
            // 
            // labelCreateHygiena
            // 
            this.labelCreateHygiena.AutoSize = true;
            this.labelCreateHygiena.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateHygiena.Location = new System.Drawing.Point(112, 260);
            this.labelCreateHygiena.Name = "labelCreateHygiena";
            this.labelCreateHygiena.Size = new System.Drawing.Size(68, 20);
            this.labelCreateHygiena.TabIndex = 8;
            this.labelCreateHygiena.Text = "Hygiena";
            // 
            // labelCreateHravost
            // 
            this.labelCreateHravost.AutoSize = true;
            this.labelCreateHravost.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateHravost.Location = new System.Drawing.Point(112, 293);
            this.labelCreateHravost.Name = "labelCreateHravost";
            this.labelCreateHravost.Size = new System.Drawing.Size(73, 20);
            this.labelCreateHravost.TabIndex = 9;
            this.labelCreateHravost.Text = "Hravost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Spánek";
            // 
            // labelCreateSpanek
            // 
            this.labelCreateSpanek.AutoSize = true;
            this.labelCreateSpanek.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateSpanek.Location = new System.Drawing.Point(112, 326);
            this.labelCreateSpanek.Name = "labelCreateSpanek";
            this.labelCreateSpanek.Size = new System.Drawing.Size(62, 20);
            this.labelCreateSpanek.TabIndex = 11;
            this.labelCreateSpanek.Text = "Spánek";
            // 
            // FormNewPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(465, 374);
            this.ControlBox = false;
            this.Controls.Add(this.labelCreateSpanek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCreateHravost);
            this.Controls.Add(this.labelCreateHygiena);
            this.Controls.Add(this.labelCreateHlad);
            this.Controls.Add(this.labelCreate3);
            this.Controls.Add(this.labelCreate2);
            this.Controls.Add(this.labelCreate1);
            this.Controls.Add(this.labelNewPet);
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
        private System.Windows.Forms.Label labelNewPet;
        private System.Windows.Forms.Label labelCreate1;
        private System.Windows.Forms.Label labelCreate2;
        private System.Windows.Forms.Label labelCreate3;
        private System.Windows.Forms.Label labelCreateHlad;
        private System.Windows.Forms.Label labelCreateHygiena;
        private System.Windows.Forms.Label labelCreateHravost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCreateSpanek;
    }
}