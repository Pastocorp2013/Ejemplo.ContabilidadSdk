using SdkContabilidad.Integrator.Schemas;
using SdkContabilidad.Integrator.Services;
using System;
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
            _service = new ConceptService();
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

        private void btnGetById_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtName.Text = "";
            int number;
            if (int.TryParse(txtId.Text, out number))
            {
                var result = _service.BuscarPorId(number);
                if (result != null)
                {
                    txtNumber.Text = result.Id.ToString();
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ConceptoDto conceptoDto = new ConceptoDto
            {
                Nombre = txtName.Text
            };

            int number;
            if (!int.TryParse(txtNumber.Text, out number))
            {
                MessageBox.Show("El número ingresadao es incorrecto.");
            }

            conceptoDto.Numero = number;

            var result = _service.Crear(conceptoDto);
            
            if (result == 0)
            {
                MessageBox.Show($"No se pudo crear el Concepto {txtName}.");
            }
            else
            {
                MessageBox.Show($"Concepto creado correctamente.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            int number;
            if (!int.TryParse(txtId.Text, out number))
            {
                MessageBox.Show("El número ingresadao es incorrecto.");
            }

            var result = _service.Borrar(number);

            if (result)
            {
                MessageBox.Show($"Concepto {number} borrado correctamente.");
            }
            else
            {
                MessageBox.Show($"Concepto borrado correctamente.");
            }
        }
    }
}
