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
    public partial class RegEstEnt : System.Windows.Forms.Form
    {
        public RegEstEnt()
        {
            InitializeComponent();
        }
        NpgsqlCommand cmd = new NpgsqlCommand();
        String str;
       


        private void btnAddEst_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO entrena VALUES("
               + cboIDEntSearch.Text + ", "
               + cboIDAdd.Text + ")";

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

        private void btnDelEst_Click(object sender, EventArgs e)
        {
              string str = "DELETE FROM entrena where ID = "
                + cboIDDel.Text;

            try
            {
                cmd.Connection = Main2.conn;
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro insertado");


                foreach (Control c in this.Controls)
                    if (c is ComboBox)
                        c.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegEstEnt_Load(object sender, EventArgs e)
        {
            string str, str2;


            try
            {
                GridEntEst.AllowUserToAddRows = false;
                GridEntEst.ColumnCount = 4;
                GridEntEst.RowCount = 0;

                GridEntEst.Columns[0].HeaderText = "ID_entrenador";
                GridEntEst.Columns[1].HeaderText = "Nombre Entrenador";
                GridEntEst.Columns[2].HeaderText = "ID Estudiante";
                GridEntEst.Columns[3].HeaderText = "Nombre Estudiante";
                


                str = "SELECT entrena.ID_entrenador, entrenador.Nombre || ' ' || entrenador.apellido as nombre_entrenador"
                    +", entrena.ID as ID_estudiante, estudiante.nombre || ' ' || estudiante.apellido as nombre_estudiante"
                    +" FROM entrena, entrenador, estudiante"
                    + " WHERE entrena.id_entrenador = entrenador.id_entrenador and entrena.id = estudiante.id";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = str;
                cmd.Connection = Main2.conn;
                NpgsqlDataReader dr = cmd.ExecuteReader();

               

                while (dr.Read())
                {
                    cboDelEst.Items.Add(dr[3]);
                    cboIDDel.Items.Add(dr[2]);

                    GridEntEst.Rows.Add();
                    GridEntEst.Rows[GridEntEst.RowCount - 1].Cells[0].Value = dr[0];
                    GridEntEst.Rows[GridEntEst.RowCount - 1].Cells[1].Value = dr[1];
                    GridEntEst.Rows[GridEntEst.RowCount - 1].Cells[2].Value = dr[2];
                    GridEntEst.Rows[GridEntEst.RowCount - 1].Cells[3].Value = dr[3];
                   

                }
                dr.Close();

                str2 = "SELECT ID_entrenador, nombre || ' ' || apellido from entrenador";
                NpgsqlCommand cmd2 = new NpgsqlCommand();
                cmd2.CommandText = str2;
                cmd2.Connection = Main2.conn;
                NpgsqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    cboEntSearch.Items.Add(dr2[1]);
                    cboIDEntSearch.Items.Add(dr2[0]);
                }
                dr2.Close();

                str = "SELECT ID, nombre || ' ' || apellido from estudiante";
                cmd.CommandText = str;
                NpgsqlDataReader dr3 = cmd.ExecuteReader();

                while (dr3.Read())
                {
                    cboAddEst.Items.Add(dr3[1]);
                    cboIDAdd.Items.Add(dr3[0]);
                }
                dr3.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

       

        private void CboEntSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
             cboIDEntSearch.SelectedIndex = cboEntSearch.SelectedIndex;
        }

        private void CboAddEst_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboIDAdd.SelectedIndex = cboAddEst.SelectedIndex;
        }

        private void CboDelEst_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboIDDel.SelectedIndex = cboDelEst.SelectedIndex;
        }
    }
}
