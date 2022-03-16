using SdkContabilidad.Integrator.Schemas;
using SdkContabilidad.Integrator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SdkContabilidad.Example.FrontPanels
{
    public partial class ConceptForm : Form
    {
        private readonly ConceptService _service;
        public ConceptForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //_service = new ConceptService();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var result = _service.BuscarTodosPorNumero();
            
            dgResult.DataSource = null;
            dgResult.DataSource = result;
        }

        private void btnGetByNumber_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            int number;
            if(int.TryParse(txtNumber.Text, out number))
            {
                var result = _service.BuscarPorNumero(number);
                if(result != null)
                {
                    txtId.Text = result.Id.ToString();
                    txtName.Name = result.Nombre;
                }
                else
                {
                    MessageBox.Show($"No se encontró el Concepto {number}.");
                }
            }
            else
            {
                MessageBox.Show("El número ingresadao es incorrecto.");
            }
            
        }
    }
}
