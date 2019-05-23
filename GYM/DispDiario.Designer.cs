namespace GYM
{
    partial class DispDiario
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
            this.gridDia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDia)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDia
            // 
            this.gridDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDia.Location = new System.Drawing.Point(13, 16);
            this.gridDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridDia.Name = "gridDia";
            this.gridDia.Size = new System.Drawing.Size(751, 524);
            this.gridDia.TabIndex = 0;
            // 
            // DispDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 553);
            this.Controls.Add(this.gridDia);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DispDiario";
            this.Load += new System.EventHandler(this.DispDiario_Load);
            this.Controls.SetChildIndex(this.gridDia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDia;
    }
}