using DataGridView.Edicao;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.QuerysInnerJoinDataSet1.CarrosRow;

            this.carrosTableAdapter.DeleteQuery(carSelect.Id);
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoCarros editCarro = new frmEdicaoCarros();
                        editCarro.ShowDialog();
                    }
                    break;
            }

            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form6 frmMarcas = new Form6();
            frmMarcas.ShowDialog();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Form7 frmvendas = new Form7();
            frmvendas.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form8 frmUsuario = new Form8();
            frmUsuario.ShowDialog();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 Adicionar = new Form1();
            Adicionar.ShowDialog();
        }
        private void Vendas_Load(object sender, EventArgs e)
        {
            frmAdicionarVendas adicionarvendas = new frmAdicionarVendas();
            adicionarvendas.ToString();
        }
    }

    internal class frmAdicionarVendas
    {
    }
}
