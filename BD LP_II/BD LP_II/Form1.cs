using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_LP_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void centro_trabajoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.centro_trabajoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOPPELDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.puestosTableAdapter.Fill(this.cOPPELDataSet.Puestos);
            this.directivosTableAdapter.Fill(this.cOPPELDataSet.Directivos);
            this.empleadosTableAdapter.Fill(this.cOPPELDataSet.Empleados);     
            this.centro_trabajoTableAdapter.Fill(this.cOPPELDataSet.Centro_trabajo);
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.centro_trabajoTableAdapter.FillBy(this.cOPPELDataSet.Centro_trabajo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
