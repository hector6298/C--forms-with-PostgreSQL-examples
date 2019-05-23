namespace GYM
{
    partial class DelEnt
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "o";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Ingrese ID";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(18, 129);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(169, 20);
            this.tbNom.TabIndex = 10;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(18, 113);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(85, 13);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Ingrese Nombre:";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(67, 166);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(18, 61);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(169, 20);
            this.tbID.TabIndex = 7;
            // 
            // DelEnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 203);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbID);
            this.Name = "DelEnt";
            this.Text = "Eliminar Entrenador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbID;
    }
}