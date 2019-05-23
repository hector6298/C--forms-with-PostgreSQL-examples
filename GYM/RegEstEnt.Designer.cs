namespace GYM
{
    partial class RegEstEnt
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
            this.cboEntSearch = new System.Windows.Forms.ComboBox();
            this.cboDelEst = new System.Windows.Forms.ComboBox();
            this.btnDelEst = new System.Windows.Forms.Button();
            this.GridEntEst = new System.Windows.Forms.DataGridView();
            this.cboAddEst = new System.Windows.Forms.ComboBox();
            this.btnAddEst = new System.Windows.Forms.Button();
            this.lblEntSearch = new System.Windows.Forms.Label();
            this.cboIDAdd = new System.Windows.Forms.ComboBox();
            this.cboIDDel = new System.Windows.Forms.ComboBox();
            this.cboIDEntSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridEntEst)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEntSearch
            // 
            this.cboEntSearch.FormattingEnabled = true;
            this.cboEntSearch.Location = new System.Drawing.Point(12, 57);
            this.cboEntSearch.Name = "cboEntSearch";
            this.cboEntSearch.Size = new System.Drawing.Size(303, 21);
            this.cboEntSearch.TabIndex = 0;
            this.cboEntSearch.SelectedIndexChanged += new System.EventHandler(this.CboEntSearch_SelectedIndexChanged);
            // 
            // cboDelEst
            // 
            this.cboDelEst.FormattingEnabled = true;
            this.cboDelEst.Location = new System.Drawing.Point(450, 57);
            this.cboDelEst.Name = "cboDelEst";
            this.cboDelEst.Size = new System.Drawing.Size(253, 21);
            this.cboDelEst.TabIndex = 1;
            this.cboDelEst.SelectedIndexChanged += new System.EventHandler(this.CboDelEst_SelectedIndexChanged);
            // 
            // btnDelEst
            // 
            this.btnDelEst.Location = new System.Drawing.Point(709, 57);
            this.btnDelEst.Name = "btnDelEst";
            this.btnDelEst.Size = new System.Drawing.Size(75, 23);
            this.btnDelEst.TabIndex = 2;
            this.btnDelEst.Text = "Eliminar";
            this.btnDelEst.UseVisualStyleBackColor = true;
            this.btnDelEst.Click += new System.EventHandler(this.btnDelEst_Click);
            // 
            // GridEntEst
            // 
            this.GridEntEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEntEst.Location = new System.Drawing.Point(12, 84);
            this.GridEntEst.Name = "GridEntEst";
            this.GridEntEst.Size = new System.Drawing.Size(776, 354);
            this.GridEntEst.TabIndex = 3;
            // 
            // cboAddEst
            // 
            this.cboAddEst.FormattingEnabled = true;
            this.cboAddEst.Location = new System.Drawing.Point(450, 28);
            this.cboAddEst.Name = "cboAddEst";
            this.cboAddEst.Size = new System.Drawing.Size(253, 21);
            this.cboAddEst.TabIndex = 4;
            this.cboAddEst.SelectedIndexChanged += new System.EventHandler(this.CboAddEst_SelectedIndexChanged);
            // 
            // btnAddEst
            // 
            this.btnAddEst.Location = new System.Drawing.Point(709, 28);
            this.btnAddEst.Name = "btnAddEst";
            this.btnAddEst.Size = new System.Drawing.Size(75, 23);
            this.btnAddEst.TabIndex = 5;
            this.btnAddEst.Text = "Agregar";
            this.btnAddEst.UseVisualStyleBackColor = true;
            this.btnAddEst.Click += new System.EventHandler(this.btnAddEst_Click);
            // 
            // lblEntSearch
            // 
            this.lblEntSearch.AutoSize = true;
            this.lblEntSearch.Location = new System.Drawing.Point(12, 38);
            this.lblEntSearch.Name = "lblEntSearch";
            this.lblEntSearch.Size = new System.Drawing.Size(118, 13);
            this.lblEntSearch.TabIndex = 6;
            this.lblEntSearch.Text = "Seleccionar Entrenador";
            // 
            // cboIDAdd
            // 
            this.cboIDAdd.FormattingEnabled = true;
            this.cboIDAdd.Location = new System.Drawing.Point(323, 28);
            this.cboIDAdd.Name = "cboIDAdd";
            this.cboIDAdd.Size = new System.Drawing.Size(121, 21);
            this.cboIDAdd.TabIndex = 7;
            // 
            // cboIDDel
            // 
            this.cboIDDel.FormattingEnabled = true;
            this.cboIDDel.Location = new System.Drawing.Point(323, 55);
            this.cboIDDel.Name = "cboIDDel";
            this.cboIDDel.Size = new System.Drawing.Size(121, 21);
            this.cboIDDel.TabIndex = 8;
            // 
            // cboIDEntSearch
            // 
            this.cboIDEntSearch.FormattingEnabled = true;
            this.cboIDEntSearch.Location = new System.Drawing.Point(196, 28);
            this.cboIDEntSearch.Name = "cboIDEntSearch";
            this.cboIDEntSearch.Size = new System.Drawing.Size(121, 21);
            this.cboIDEntSearch.TabIndex = 9;
            // 
            // RegEstEnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboIDEntSearch);
            this.Controls.Add(this.cboIDDel);
            this.Controls.Add(this.cboIDAdd);
            this.Controls.Add(this.lblEntSearch);
            this.Controls.Add(this.btnAddEst);
            this.Controls.Add(this.cboAddEst);
            this.Controls.Add(this.GridEntEst);
            this.Controls.Add(this.btnDelEst);
            this.Controls.Add(this.cboDelEst);
            this.Controls.Add(this.cboEntSearch);
            this.Name = "RegEstEnt";
            this.Text = "Agregar o eliminar estudiantes";
            this.Load += new System.EventHandler(this.RegEstEnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEntEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEntSearch;
        private System.Windows.Forms.ComboBox cboDelEst;
        private System.Windows.Forms.Button btnDelEst;
        private System.Windows.Forms.DataGridView GridEntEst;
        private System.Windows.Forms.ComboBox cboAddEst;
        private System.Windows.Forms.Button btnAddEst;
        private System.Windows.Forms.Label lblEntSearch;
        private System.Windows.Forms.ComboBox cboIDAdd;
        private System.Windows.Forms.ComboBox cboIDDel;
        private System.Windows.Forms.ComboBox cboIDEntSearch;
    }
}