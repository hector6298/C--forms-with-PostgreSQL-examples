namespace GYM
{
    partial class MainEst
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
            this.btnReg = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.gridEst = new System.Windows.Forms.DataGridView();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboIDSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEst)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(15, 12);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(146, 60);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "Registrar/Actualizar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(183, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(146, 60);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Eliminar Registro";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // gridEst
            // 
            this.gridEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEst.Location = new System.Drawing.Point(15, 96);
            this.gridEst.Name = "gridEst";
            this.gridEst.Size = new System.Drawing.Size(971, 521);
            this.gridEst.TabIndex = 4;
            this.gridEst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEst_CellContentClick);
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(621, 51);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(365, 21);
            this.cboSearch.TabIndex = 5;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.CboSearch_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(618, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 13);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Buscar Estudiante";
            // 
            // cboIDSearch
            // 
            this.cboIDSearch.FormattingEnabled = true;
            this.cboIDSearch.Location = new System.Drawing.Point(842, 24);
            this.cboIDSearch.Name = "cboIDSearch";
            this.cboIDSearch.Size = new System.Drawing.Size(144, 21);
            this.cboIDSearch.TabIndex = 8;
            this.cboIDSearch.SelectedIndexChanged += new System.EventHandler(this.CboIDSearch_SelectedIndexChanged);
            // 
            // MainEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 629);
            this.Controls.Add(this.cboIDSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.gridEst);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnReg);
            this.Name = "MainEst";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.MainEst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView gridEst;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cboIDSearch;
    }
}