namespace GYM
{
    partial class MainImp
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
            this.GridImp = new System.Windows.Forms.DataGridView();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboCodSearch = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridImp)).BeginInit();
            this.SuspendLayout();
            // 
            // GridImp
            // 
            this.GridImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridImp.Location = new System.Drawing.Point(12, 70);
            this.GridImp.Name = "GridImp";
            this.GridImp.Size = new System.Drawing.Size(776, 368);
            this.GridImp.TabIndex = 0;
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(12, 43);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(286, 21);
            this.cboSearch.TabIndex = 1;
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.CboSearch_SelectedIndexChanged);
            this.cboSearch.SelectedValueChanged += new System.EventHandler(this.CboSearch_SelectedValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(624, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 54);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 27);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(104, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Buscar implementos:";
            // 
            // cboCodSearch
            // 
            this.cboCodSearch.FormattingEnabled = true;
            this.cboCodSearch.Location = new System.Drawing.Point(168, 16);
            this.cboCodSearch.Name = "cboCodSearch";
            this.cboCodSearch.Size = new System.Drawing.Size(130, 21);
            this.cboCodSearch.TabIndex = 5;
            this.cboCodSearch.SelectedIndexChanged += new System.EventHandler(this.CboCodSearch_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(315, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(164, 54);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // MainImp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboCodSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.GridImp);
            this.Name = "MainImp";
            this.Text = "Implementos del gimnasio";
            this.Load += new System.EventHandler(this.MainImp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridImp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridImp;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cboCodSearch;
        private System.Windows.Forms.Button btnBuscar;
    }
}