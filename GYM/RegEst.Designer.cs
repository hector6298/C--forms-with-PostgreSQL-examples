namespace GYM
{
    partial class RegEst
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbApel = new System.Windows.Forms.TextBox();
            this.tbSemestre = new System.Windows.Forms.TextBox();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblApel = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tbID);
            this.flowLayoutPanel1.Controls.Add(this.tbNom);
            this.flowLayoutPanel1.Controls.Add(this.tbApel);
            this.flowLayoutPanel1.Controls.Add(this.tbSemestre);
            this.flowLayoutPanel1.Controls.Add(this.tbCarrera);
            this.flowLayoutPanel1.Controls.Add(this.tbTel);
            this.flowLayoutPanel1.Controls.Add(this.tbRes);
            this.flowLayoutPanel1.Controls.Add(this.btnReg);
            this.flowLayoutPanel1.Controls.Add(this.btnAct);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 217);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(3, 3);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(241, 20);
            this.tbID.TabIndex = 0;
            this.tbID.TextChanged += new System.EventHandler(this.TbID_TextChanged);
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
            this.tbApel.TabIndex = 1;
            // 
            // tbSemestre
            // 
            this.tbSemestre.Location = new System.Drawing.Point(3, 81);
            this.tbSemestre.Name = "tbSemestre";
            this.tbSemestre.Size = new System.Drawing.Size(241, 20);
            this.tbSemestre.TabIndex = 2;
            // 
            // tbCarrera
            // 
            this.tbCarrera.Location = new System.Drawing.Point(3, 107);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(241, 20);
            this.tbCarrera.TabIndex = 3;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(3, 133);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(241, 20);
            this.tbTel.TabIndex = 5;
            // 
            // tbRes
            // 
            this.tbRes.Location = new System.Drawing.Point(3, 159);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(241, 20);
            this.tbRes.TabIndex = 6;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(3, 185);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(84, 185);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 2;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.BtnAct_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(271, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.LblID_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(271, 61);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Nombre";
            // 
            // lblApel
            // 
            this.lblApel.AutoSize = true;
            this.lblApel.Location = new System.Drawing.Point(271, 87);
            this.lblApel.Name = "lblApel";
            this.lblApel.Size = new System.Drawing.Size(44, 13);
            this.lblApel.TabIndex = 12;
            this.lblApel.Text = "Apellido";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(271, 113);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(51, 13);
            this.lblSemestre.TabIndex = 13;
            this.lblSemestre.Text = "Semestre";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(271, 139);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 14;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(271, 165);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 15;
            this.lblTel.Text = "Telefono";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(271, 191);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(60, 13);
            this.lblRes.TabIndex = 16;
            this.lblRes.Text = "Residencia";
            // 
            // RegEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 248);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblSemestre);
            this.Controls.Add(this.lblApel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RegEst";
            this.Text = "Registrar Estudiante";
            this.Load += new System.EventHandler(this.RegEst_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbApel;
        private System.Windows.Forms.TextBox tbSemestre;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblApel;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblRes;
    }
}