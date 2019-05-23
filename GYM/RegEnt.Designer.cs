namespace GYM
{
    partial class RegEnt
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
            this.lblApel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbApel = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.btnAct = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApel
            // 
            this.lblApel.AutoSize = true;
            this.lblApel.Location = new System.Drawing.Point(271, 95);
            this.lblApel.Name = "lblApel";
            this.lblApel.Size = new System.Drawing.Size(44, 13);
            this.lblApel.TabIndex = 20;
            this.lblApel.Text = "Apellido";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(271, 69);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 19;
            this.lblNom.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(271, 43);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tbID);
            this.flowLayoutPanel1.Controls.Add(this.tbNom);
            this.flowLayoutPanel1.Controls.Add(this.tbApel);
            this.flowLayoutPanel1.Controls.Add(this.tbTel);
            this.flowLayoutPanel1.Controls.Add(this.btnReg);
            this.flowLayoutPanel1.Controls.Add(this.btnAct);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 133);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(3, 29);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(241, 20);
            this.tbNom.TabIndex = 4;
            // 
            // tbApel
            // 
            this.tbApel.Location = new System.Drawing.Point(3, 55);
            this.tbApel.Name = "tbApel";
            this.tbApel.Size = new System.Drawing.Size(241, 20);
            this.tbApel.TabIndex = 0;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(3, 81);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(241, 20);
            this.tbTel.TabIndex = 1;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(3, 107);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(3, 3);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(241, 20);
            this.tbID.TabIndex = 5;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(271, 118);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 21;
            this.lblTel.Text = "Telefono";
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(84, 107);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 6;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.BtnAct_Click);
            // 
            // RegEnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 182);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblApel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RegEnt";
            this.Text = "Registrar Entrenador";
            this.Load += new System.EventHandler(this.RegEnt_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbApel;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Button btnAct;
    }
}