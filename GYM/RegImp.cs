using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace GYM
{
    public partial class RegImp : System.Windows.Forms.Form
    {
        public RegImp()
        {
            InitializeComponent();
        }
        NpgsqlCommand cmd = new NpgsqlCommand();

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO equipamento VALUES("
               + tbCod.Text + ", '"
               + tbDesc.Text + "', '"
               + tbMarca.Text + "', '"
               + tbState.Text + "', '"
               + tbTipo.Text + "', "
               + tbValor.Text + ")";
              

            try
            {
                cmd.Connection = Main2.conn;
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro insertado");


                foreach (Control c in this.Controls)
                    if (c is TextBox)
                        c.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        
    }
}
