namespace GYM
{
    partial class Main2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2));
            this.btnEst = new System.Windows.Forms.Button();
            this.btnEnt = new System.Windows.Forms.Button();
            this.bntMens = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.tbReg_D = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReg_D = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.btnDia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEst
            // 
            this.btnEst.Location = new System.Drawing.Point(12, 22);
            this.btnEst.Name = "btnEst";
            this.btnEst.Size = new System.Drawing.Size(396, 184);
            this.btnEst.TabIndex = 0;
            this.btnEst.Text = "Estudiantes";
            this.btnEst.UseVisualStyleBackColor = true;
            this.btnEst.Click += new System.EventHandler(this.BtnEst_Click);
            // 
            // btnEnt
            // 
            this.btnEnt.Location = new System.Drawing.Point(12, 212);
            this.btnEnt.Name = "btnEnt";
            this.btnEnt.Size = new System.Drawing.Size(396, 186);
            this.btnEnt.TabIndex = 1;
            this.btnEnt.Text = "Entrenadores";
            this.btnEnt.UseVisualStyleBackColor = true;
            this.btnEnt.Click += new System.EventHandler(this.BtnEnt_Click);
            // 
            // bntMens
            // 
            this.bntMens.Location = new System.Drawing.Point(414, 22);
            this.bntMens.Name = "bntMens";
            this.bntMens.Size = new System.Drawing.Size(374, 184);
            this.bntMens.TabIndex = 2;
            this.bntMens.Text = "Mensualidades";
            this.bntMens.UseVisualStyleBackColor = true;
            this.bntMens.Click += new System.EventHandler(this.BntMens_Click);
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(414, 212);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(374, 186);
            this.btnImp.TabIndex = 3;
            this.btnImp.Text = "Implementos";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.BtnImp_Click);
            // 
            // tbReg_D
            // 
            this.tbReg_D.Location = new System.Drawing.Point(3, 3);
            this.tbReg_D.Name = "tbReg_D";
            this.tbReg_D.Size = new System.Drawing.Size(244, 20);
            this.tbReg_D.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbReg_D);
            this.flowLayoutPanel1.Controls.Add(this.btnReg_D);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(414, 412);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(374, 26);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnReg_D
            // 
            this.btnReg_D.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnReg_D.Location = new System.Drawing.Point(253, 3);
            this.btnReg_D.Name = "btnReg_D";
            this.btnReg_D.Size = new System.Drawing.Size(110, 23);
            this.btnReg_D.TabIndex = 5;
            this.btnReg_D.Text = "Registrar";
            this.btnReg_D.UseVisualStyleBackColor = true;
            this.btnReg_D.Click += new System.EventHandler(this.BtnReg_D_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(302, 418);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(106, 13);
            this.lblReg.TabIndex = 7;
            this.lblReg.Text = "Registro diario por ID";
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(12, 412);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(153, 23);
            this.btnDia.TabIndex = 8;
            this.btnDia.Text = "Mostrar registro diario";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.BtnDia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 227);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnImp);
            this.Controls.Add(this.bntMens);
            this.Controls.Add(this.btnEnt);
            this.Controls.Add(this.btnEst);
            this.Name = "Main2";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.Main_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEst;
        private System.Windows.Forms.Button btnEnt;
        private System.Windows.Forms.Button bntMens;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.TextBox tbReg_D;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnReg_D;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

