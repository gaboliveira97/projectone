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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Vendas' table. You can move, or remove it, as needed.
            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var VendaSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as DataGridView.QuerysInnerJoinDataSet1.CarrosRow;

            this.vendasTableAdapter.DeleteQuery(VendaSelect.Id);
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }
    }
}
