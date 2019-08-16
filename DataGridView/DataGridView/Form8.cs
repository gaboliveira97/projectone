using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Usuarios' table. You can move, or remove it, as needed.
            //this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet2.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var UsuarioSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
             as DataGridView.QuerysInnerJoinDataSet1.CarrosRow;

            this.usuariosTableAdapter.DeleteQuery(UsuarioSelect.Id);
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);
        }
    }
}
