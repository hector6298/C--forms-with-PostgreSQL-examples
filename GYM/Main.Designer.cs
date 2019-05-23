namespace GYM
{
    partial class Main
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
            this.btnIng = new System.Windows.Forms.Button();
            this.tbUs = new System.Windows.Forms.TextBox();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.tbCon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIng
            // 
            this.btnIng.Location = new System.Drawing.Point(15, 90);
            this.btnIng.Name = "btnIng";
            this.btnIng.Size = new System.Drawing.Size(100, 23);
            this.btnIng.TabIndex = 0;
            this.btnIng.Text = "Ingresar";
            this.btnIng.UseVisualStyleBackColor = true;
            this.btnIng.Click += new System.EventHandler(this.BtnIng_Click);
            // 
            // tbUs
            // 
            this.tbUs.Location = new System.Drawing.Point(15, 25);
            this.tbUs.Name = "tbUs";
            this.tbUs.Size = new System.Drawing.Size(100, 20);
            this.tbUs.TabIndex = 1;
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Location = new System.Drawing.Point(12, 9);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(46, 13);
            this.lblUs.TabIndex = 2;
            this.lblUs.Text = "Usuario:";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(12, 48);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(64, 13);
            this.lblCon.TabIndex = 3;
            this.lblCon.Text = "Contrasena:";
            // 
            // tbCon
            // 
            this.tbCon.Location = new System.Drawing.Point(15, 64);
            this.tbCon.Name = "tbCon";
            this.tbCon.PasswordChar = '*';
            this.tbCon.Size = new System.Drawing.Size(100, 20);
            this.tbCon.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(135, 130);
            this.Controls.Add(this.tbCon);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.tbUs);
            this.Controls.Add(this.btnIng);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIng;
        private System.Windows.Forms.TextBox tbUs;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.TextBox tbCon;
    }
}