namespace GYM
{
    partial class MainEnt
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
            this.lblEntSearch = new System.Windows.Forms.Label();
            this.cboEntSearch = new System.Windows.Forms.ComboBox();
            this.GridEnt = new System.Windows.Forms.DataGridView();
            this.btnRegEst_Ent = new System.Windows.Forms.Button();
            this.btnDelEnt = new System.Windows.Forms.Button();
            this.btnRegEnt = new System.Windows.Forms.Button();
            this.cboIDSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridEnt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntSearch
            // 
            this.lblEntSearch.AutoSize = true;
            this.lblEntSearch.Location = new System.Drawing.Point(617, 33);
            this.lblEntSearch.Name = "lblEntSearch";
            this.lblEntSearch.Size = new System.Drawing.Size(95, 13);
            this.lblEntSearch.TabIndex = 14;
            this.lblEntSearch.Text = "Buscar Entrenador";
            // 
            // cboEntSearch
            // 
            this.cboEntSearch.FormattingEnabled = true;
            this.cboEntSearch.Location = new System.Drawing.Point(620, 49);
            this.cboEntSearch.Name = "cboEntSearch";
            this.cboEntSearch.Size = new System.Drawing.Size(365, 21);
            this.cboEntSearch.TabIndex = 12;
            this.cboEntSearch.SelectedIndexChanged += new System.EventHandler(this.CboEntSearch_SelectedIndexChanged);
            // 
            // GridEnt
            // 
            this.GridEnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEnt.Location = new System.Drawing.Point(14, 94);
            this.GridEnt.Name = "GridEnt";
            this.GridEnt.Size = new System.Drawing.Size(971, 521);
            this.GridEnt.TabIndex = 11;
            // 
            // btnRegEst_Ent
            // 
            this.btnRegEst_Ent.Location = new System.Drawing.Point(353, 10);
            this.btnRegEst_Ent.Name = "btnRegEst_Ent";
            this.btnRegEst_Ent.Size = new System.Drawing.Size(146, 60);
            this.btnRegEst_Ent.TabIndex = 10;
            this.btnRegEst_Ent.Text = "Registrar Estudiante";
            this.btnRegEst_Ent.UseVisualStyleBackColor = true;
            this.btnRegEst_Ent.Click += new System.EventHandler(this.BtnRegEst_Ent_Click);
            // 
            // btnDelEnt
            // 
            this.btnDelEnt.Location = new System.Drawing.Point(182, 10);
            this.btnDelEnt.Name = "btnDelEnt";
            this.btnDelEnt.Size = new System.Drawing.Size(146, 60);
            this.btnDelEnt.TabIndex = 9;
            this.btnDelEnt.Text = "Eliminar Entrenador";
            this.btnDelEnt.UseVisualStyleBackColor = true;
            this.btnDelEnt.Click += new System.EventHandler(this.BtnDelEnt_Click);
            // 
            // btnRegEnt
            // 
            this.btnRegEnt.Location = new System.Drawing.Point(14, 10);
            this.btnRegEnt.Name = "btnRegEnt";
            this.btnRegEnt.Size = new System.Drawing.Size(146, 60);
            this.btnRegEnt.TabIndex = 8;
            this.btnRegEnt.Text = "Registrar/Actualizar";
            this.btnRegEnt.UseVisualStyleBackColor = true;
            this.btnRegEnt.Click += new System.EventHandler(this.btnRegEnt_Click);
            // 
            // cboIDSearch
            // 
            this.cboIDSearch.FormattingEnabled = true;
            this.cboIDSearch.Location = new System.Drawing.Point(864, 22);
            this.cboIDSearch.Name = "cboIDSearch";
            this.cboIDSearch.Size = new System.Drawing.Size(122, 21);
            this.cboIDSearch.TabIndex = 15;
            this.cboIDSearch.SelectedIndexChanged += new System.EventHandler(this.CboIDSearch_SelectedIndexChanged);
            // 
            // MainEnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 629);
            this.Controls.Add(this.cboIDSearch);
            this.Controls.Add(this.lblEntSearch);
            this.Controls.Add(this.cboEntSearch);
            this.Controls.Add(this.GridEnt);
            this.Controls.Add(this.btnRegEst_Ent);
            this.Controls.Add(this.btnDelEnt);
            this.Controls.Add(this.btnRegEnt);
            this.Name = "MainEnt";
            this.Text = "Entrenadores";
            this.Load += new System.EventHandler(this.MainEnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntSearch;
        private System.Windows.Forms.ComboBox cboEntSearch;
        private System.Windows.Forms.DataGridView GridEnt;
        private System.Windows.Forms.Button btnRegEst_Ent;
        private System.Windows.Forms.Button btnDelEnt;
        private System.Windows.Forms.Button btnRegEnt;
        private System.Windows.Forms.ComboBox cboIDSearch;
    }
}