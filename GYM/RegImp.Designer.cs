namespace GYM
{
    partial class RegImp
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(271, 148);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "Tipo";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(271, 122);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(40, 13);
            this.lblState.TabIndex = 23;
            this.lblState.Text = "Estado";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(271, 96);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(271, 70);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 21;
            this.lblDesc.Text = "Descripcion";
            this.lblDesc.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(271, 44);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 20;
            this.lblValor.Text = "Valor";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(271, 18);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 19;
            this.lblCod.Text = "Código";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tbCod);
            this.flowLayoutPanel1.Controls.Add(this.tbValor);
            this.flowLayoutPanel1.Controls.Add(this.tbDesc);
            this.flowLayoutPanel1.Controls.Add(this.tbMarca);
            this.flowLayoutPanel1.Controls.Add(this.tbState);
            this.flowLayoutPanel1.Controls.Add(this.tbTipo);
            this.flowLayoutPanel1.Controls.Add(this.btnReg);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 217);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(3, 3);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(241, 20);
            this.tbCod.TabIndex = 0;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(3, 29);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(241, 20);
            this.tbValor.TabIndex = 4;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(3, 55);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(241, 20);
            this.tbDesc.TabIndex = 1;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(3, 81);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(241, 20);
            this.tbMarca.TabIndex = 2;
            this.tbMarca.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(3, 107);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(241, 20);
            this.tbState.TabIndex = 3;
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(3, 133);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(241, 20);
            this.tbTipo.TabIndex = 5;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(3, 159);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // RegImp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 213);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RegImp";
            this.Text = "Registrar Implemento";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Button btnReg;
    }
}