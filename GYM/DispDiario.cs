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
    public partial class DispDiario : Main
    {
        public DispDiario()
        {
            InitializeComponent();
        }

        private void DispDiario_Load(object sender, EventArgs e)
        {
            string str;


            try
            {
                gridDia.AllowUserToAddRows = false;
                gridDia.ColumnCount = 5;
                gridDia.RowCount = 0;

                gridDia.Columns[0].HeaderText = "ID";
                gridDia.Columns[1].HeaderText = "Nombre";
                gridDia.Columns[2].HeaderText = "Fecha";
                gridDia.Columns[3].HeaderText = "Hora";
                gridDia.Columns[4].HeaderText = "Pago Diario";
               


                str = "SELECT ID, nombre || ' ' || apellido,fecha,hora,pago_diario FROM registro_diario natural join estudiante";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = str;
                cmd.Connection = Main2.conn;
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                   
                    gridDia.Rows.Add();
                    gridDia.Rows[gridDia.RowCount - 1].Cells[0].Value = dr[0];
                    gridDia.Rows[gridDia.RowCount - 1].Cells[1].Value = dr[1];
                    gridDia.Rows[gridDia.RowCount - 1].Cells[2].Value = dr[2];
                    gridDia.Rows[gridDia.RowCount - 1].Cells[3].Value = dr[3];
                    gridDia.Rows[gridDia.RowCount - 1].Cells[4].Value = dr[4];

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
