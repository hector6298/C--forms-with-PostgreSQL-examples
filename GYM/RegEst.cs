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
    public partial class RegEst : System.Windows.Forms.Form
    {
        public RegEst()
        {
            InitializeComponent();
        }

        NpgsqlCommand cmd = new NpgsqlCommand();
        

       

        private void LblID_Click(object sender, EventArgs e)
        {

        }

        private void TbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO estudiante VALUES("
                + tbID.Text + ", '"
                + tbNom.Text + "', '"
                + tbApel.Text + "', "
                + tbSemestre.Text + ", '"
                + tbCarrera.Text + "', '"
                + tbTel.Text + "', '"
                + tbRes.Text +"',"
                + "current_date)";

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
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnAct_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM estudiante WHERE ID = " + tbID.Text;
            cmd.CommandText = sql;
            cmd.Connection = Main2.conn;
            Int64 nreg = (Int64)cmd.ExecuteScalar();

            if (nreg == 0)
            {
                MessageBox.Show("No existe ID. No se puede actualizar");
                return;
            }

            string str = "update estudiante set "
                + "semestre = '" + tbSemestre.Text + "', "
                + "carrera = '" + tbCarrera.Text + "', "
                + "telefono = '" + tbTel.Text + "', "
                + "residencia = '" + tbRes.Text + "' ";

            try
            {
                cmd.CommandText = str;
                cmd.Connection = Main2.conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

            
                
        }

        private void RegEst_Load(object sender, EventArgs e)
        {

        }
    }
}
