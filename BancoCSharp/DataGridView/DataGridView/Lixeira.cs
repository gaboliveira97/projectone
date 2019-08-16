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
    public partial class Lixeira : Form
    {
        private readonly object carrosTableAdapter1;

        public Lixeira()
        {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.GetAllData(this.querysInnerJoinDataSet1.DataTable1);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            //this.carrosTableAdapter.CustomInativeValues(this.querysInnerJoinDataSet1.Carros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var lixeiraGlobal = ((System.Data.DataRowView)
          this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
          as DataGridView.QuerysInnerJoinDataSet1.DataTable1Row;

            //caso 
            switch (lixeiraGlobal.Tabela)
            {
                //coluna que ele clicar caso o deletar
                case "carros":
                    {
                        //this.carrosTableAdapter1.UpdateQuery(lixeiraGlobal.Id);

                    }
                    break;
            }
            this.dataTable1TableAdapter.GetAllData(this.querysInnerJoinDataSet1.DataTable1);

        }

    }
}