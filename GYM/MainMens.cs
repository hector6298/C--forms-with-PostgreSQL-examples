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
    public partial class MainMens : System.Windows.Forms.Form
    {
        public MainMens()
        {
            InitializeComponent();
        }
        String str;
        
        private void MainMens_Load(object sender, EventArgs e)
        {
            try
            {
                GridMens.AllowUserToAddRows = false;
                GridMens.ColumnCount = 6;
                GridMens.RowCount = 0;

                GridMens.Columns[0].HeaderText = "id_pago";
                GridMens.Columns[1].HeaderText = "ID";
                GridMens.Columns[2].HeaderText = "Nombre ";
                GridMens.Columns[3].HeaderText = "Fecha Inicial";
                GridMens.Columns[4].HeaderText = "Fecha Termino";
                GridMens.Columns[5].HeaderText = "Monto";




                NpgsqlCommand cmd = new NpgsqlCommand();
                str = "SELECT id_pago,ID, nombre || ' ' || apellido as Nombre, "
                    + "fecha_inicial,fecha_termino,monto "
                    + "FROM registro_mensualidad natural join estudiante";

                cmd.CommandText = str;
                cmd.Connection = Main2.conn;
                NpgsqlDataReader dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    cboIDEstRen.Items.Add(dr[1]);
                    cboRen.Items.Add(dr[2]);
                    GridMens.Rows.Add();
                    GridMens.Rows[GridMens.RowCount - 1].Cells[0].Value = dr[0];
                    GridMens.Rows[GridMens.RowCount - 1].Cells[1].Value = dr[1];
                    GridMens.Rows[GridMens.RowCount - 1].Cells[2].Value = dr[2];
                    GridMens.Rows[GridMens.RowCount - 1].Cells[3].Value = dr[3];
                    GridMens.Rows[GridMens.RowCount - 1].Cells[4].Value = dr[4];
                    GridMens.Rows[GridMens.RowCount - 1].Cells[5].Value = dr[5];

                }
                dr.Close();

                NpgsqlCommand cmd2 = new NpgsqlCommand();
                str = "SELECT ID, nombre || ' ' || apellido from estudiante ";

                cmd2.CommandText = str;
                cmd2.Connection = Main2.conn;
                NpgsqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    cboIDEstAdd.Items.Add(dr2[0]);
                    cboAdd.Items.Add(dr2[1]);
                }
                dr2.Close();

                NpgsqlCommand cmd3 = new NpgsqlCommand();
                str = "SELECT ID, nombre || ' ' || apellido from registro_mensualidad natural join estudiante ";

                cmd3.CommandText = str;
                cmd3.Connection = Main2.conn;
                NpgsqlDataReader dr3 = cmd3.ExecuteReader();

                while (dr3.Read())
                {
                    cboIDEstRen.Items.Add(dr3[0]);
                    cboRen.Items.Add(dr3[1]);
                }
                dr3.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CboRen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboIDEstRen.SelectedIndex = cboRen.SelectedIndex;
        }

        private void CboAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboIDEstAdd.SelectedIndex = cboAdd.SelectedIndex;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cd = new NpgsqlCommand("SELECT max(id_pago) FROM registro_mensualidad", Main2.conn);
            int id_pago = (int)cd.ExecuteScalar();
            id_pago += 1;

            string str = "INSERT INTO registro_mensualidad VALUES("
              + "current_date" + ", "
              + "current_date + interval '1 month', "
              + "10.00, "
              + id_pago + "," 
              + cboIDEstAdd.Text +  ") ";
            
             
              

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
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

        private void BtnRen_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cd = new NpgsqlCommand("SELECT max(id_pago) FROM registro_mensualidad", Main2.conn);
            int id_pago = (int)cd.ExecuteScalar();
            id_pago += 1;

            string str = "INSERT INTO registro_mensualidad VALUES("
             + "current_date" + ", "
             + "current_date + interval '1 month', "
             + "10.00, "
             + id_pago + ","
             + cboIDEstRen.Text + ") ";
            id_pago++;



            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
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
    }
}
