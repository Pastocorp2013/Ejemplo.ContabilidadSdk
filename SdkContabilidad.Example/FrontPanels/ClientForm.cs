using SdkContabilidad.Integrator.Common;
using SdkContabilidad.Integrator.Schemas;
using SdkContabilidad.Integrator.Services;
using System;
using System.Windows.Forms;

namespace SdkContabilidad.Example.FrontPanels
{
    public partial class ClientForm : Form
    {
        private readonly ClientService _service;

        public ClientForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _service = new ClientService();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var result = _service.BuscarTodasPorRfc();

            dgResult.DataSource = null;
            dgResult.DataSource = result;
        }

        private void btnGetByAdminCode_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtId.Text, out number))
            {
                var result = _service.BuscarPorCodigoAdminPaq(txtCode.Text);
                if (result != null)
                {
                    txtName.Name = result.Nombre;
                }
                else
                {
                    MessageBox.Show($"No se encontró el Código Adminpaq {number}.");
                }
            }
            else
            {
                MessageBox.Show("El código ingresadao es incorrecto.");
            }
        }

        private void btnGetByCode_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtId.Text, out number))
            {
                var result = _service.BuscarPorCodigo(txtCode.Text);
                if (result != null)
                {
                    txtName.Name = result.Nombre;
                }
                else
                {
                    MessageBox.Show($"No se encontró el Código {number}.");
                }
            }
            else
            {
                MessageBox.Show("El código ingresadao es incorrecto.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClienteDto cuentaDto = new ClienteDto
            {
                Nombre = txtName.Text,
                Codigo = txtCode.Text,
                CURP = txtCurp.Text,
                RFC = txtRfc.Text,
                Telefono1 = txtPhone1.Text,
                Telefono2 = txtPhone1.Text,
                Telefono3 = txtPhone1.Text,
                FechaRegistro = dtStartDate.Value,
                Fax = txtFax.Text,
                eMail = txtEmail.Text,
                PaginaWeb = txtWebPage.Text,
                IdDatoExtra = txtIdExtraData.Text.ToInt(),
                EsCliente = txtIsClient.Text.ToInt(),
                EsProveedor = txtIsProv.Text.ToInt(),
                EsAgente = txtIsAgent.Text.ToInt(),
                EsPersona = txtIsPerson.Text.ToInt(),
            };

            var result = _service.Crear(cuentaDto);

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
            string code = txtCode.Text;
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("El código ingresadao es incorrecto.");
            }

            var result = _service.Borrar(code);

            if (result)
            {
                MessageBox.Show($"Cuenta {code} borrada correctamente.");
            }
            else
            {
                MessageBox.Show($"código borrada correctamente.");
            }
        }
    }
}
