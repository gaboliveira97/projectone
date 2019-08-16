using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVisualizacaoValores.Model;

namespace TabelaDeVisualizacaoValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Contrac> listContracs = new List<Contrac>();

        private void Button1_Click(object sender, EventArgs e)
        {
            listContracs.Add(new Contrac()
            {
                Value = new Random().Next(100),
                DatInc = DateTime.Now
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listContracs;

        }
    }
}
