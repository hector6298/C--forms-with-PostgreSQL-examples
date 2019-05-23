namespace GYM
{
    partial class MainMens
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
            this.GridMens = new System.Windows.Forms.DataGridView();
            this.btnRen = new System.Windows.Forms.Button();
            this.cboRen = new System.Windows.Forms.ComboBox();
            this.cboAdd = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRen = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.cboIDEstAdd = new System.Windows.Forms.ComboBox();
            this.cboIDEstRen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridMens)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMens
            // 
            this.GridMens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMens.Location = new System.Drawing.Point(12, 59);
            this.GridMens.Name = "GridMens";
            this.GridMens.Size = new System.Drawing.Size(776, 379);
            this.GridMens.TabIndex = 0;
            // 
            // btnRen
            // 
            this.btnRen.Location = new System.Drawing.Point(276, 30);
            this.btnRen.Name = "btnRen";
            this.btnRen.Size = new System.Drawing.Size(75, 23);
            this.btnRen.TabIndex = 1;
            this.btnRen.Text = "Renovar";
            this.btnRen.UseVisualStyleBackColor = true;
            this.btnRen.Click += new System.EventHandler(this.BtnRen_Click);
            // 
            // cboRen
            // 
            this.cboRen.FormattingEnabled = true;
            this.cboRen.Location = new System.Drawing.Point(12, 30);
            this.cboRen.Name = "cboRen";
            this.cboRen.Size = new System.Drawing.Size(258, 21);
            this.cboRen.TabIndex = 2;
            this.cboRen.SelectedIndexChanged += new System.EventHandler(this.CboRen_SelectedIndexChanged);
            // 
            // cboAdd
            // 
            this.cboAdd.FormattingEnabled = true;
            this.cboAdd.Location = new System.Drawing.Point(449, 32);
            this.cboAdd.Name = "cboAdd";
            this.cboAdd.Size = new System.Drawing.Size(258, 21);
            this.cboAdd.TabIndex = 3;
            this.cboAdd.SelectedIndexChanged += new System.EventHandler(this.CboAdd_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(713, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblRen
            // 
            this.lblRen.AutoSize = true;
            this.lblRen.Location = new System.Drawing.Point(12, 14);
            this.lblRen.Name = "lblRen";
            this.lblRen.Size = new System.Drawing.Size(178, 13);
            this.lblRen.TabIndex = 5;
            this.lblRen.Text = "Renovar mensualidad de Estudiante";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(446, 14);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(175, 13);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "Agregar Estudiante a pago mensual";
            // 
            // cboIDEstAdd
            // 
            this.cboIDEstAdd.FormattingEnabled = true;
            this.cboIDEstAdd.Location = new System.Drawing.Point(647, 6);
            this.cboIDEstAdd.Name = "cboIDEstAdd";
            this.cboIDEstAdd.Size = new System.Drawing.Size(60, 21);
            this.cboIDEstAdd.TabIndex = 7;
            // 
            // cboIDEstRen
            // 
            this.cboIDEstRen.FormattingEnabled = true;
            this.cboIDEstRen.Location = new System.Drawing.Point(196, 5);
            this.cboIDEstRen.Name = "cboIDEstRen";
            this.cboIDEstRen.Size = new System.Drawing.Size(74, 21);
            this.cboIDEstRen.TabIndex = 8;
            // 
            // MainMens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboIDEstRen);
            this.Controls.Add(this.cboIDEstAdd);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblRen);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboAdd);
            this.Controls.Add(this.cboRen);
            this.Controls.Add(this.btnRen);
            this.Controls.Add(this.GridMens);
            this.Name = "MainMens";
            this.Text = "Registrar o renovar mensualidad";
            this.Load += new System.EventHandler(this.MainMens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMens;
        private System.Windows.Forms.Button btnRen;
        private System.Windows.Forms.ComboBox cboRen;
        private System.Windows.Forms.ComboBox cboAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRen;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ComboBox cboIDEstAdd;
        private System.Windows.Forms.ComboBox cboIDEstRen;
    }
}