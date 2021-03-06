using SdkContabilidad.Integrator.Common;
using SdkContabilidad.Integrator.Schemas;
using SdkContabilidad.Integrator.Services;
using System;
using System.Windows.Forms;

namespace SdkContabilidad.Example.FrontPanels
{
    public partial class AccountForm : Form
    {
        private readonly AccountService _service;
        public AccountForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _service = new AccountService();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            var result = _service.BuscarTodasPorCodigo();

            dgResult.DataSource = null;
            dgResult.DataSource = result;
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            int number;
            if (int.TryParse(txtId.Text, out number))
            {
                var result = _service.BuscarPorId(number);
                if (result != null)
                {
                    txtCode.Text = result.Id.ToString();
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
            CuentaContableDto cuentaDto = new CuentaContableDto
            {
                Nombre = txtName.Text,
                Codigo = txtCode.Text,
                NomIdioma = txtEnglishName.Text,
                Tipo = txtType.Text.ToInt(),
                EsBaja = txtIs.Text.ToInt(),
                CtaMayor = txtMAccount.Text.ToInt(),
                FechaAlta = dtStartDate.Value,
                SistOrigen = txtSistOrigin.Text.ToInt(),
                Moneda = txtCurrency.Text.ToInt(),
                DigitoAgrupador = txtGroupDigit.Text.ToInt(),
                AplicaSegNeg = txtAcceptSegment.Text.ToInt(),
                CodigoCuentaAcumula = txtCodAccountSum.Text,
                DigitoFiscal1 = txtDig1.Text.ToInt(),
                DigitoFiscal2 = txtDig2.Text.ToInt(),
                AgrupadorSAT = txtSatGroup.Text,
                Consume = txtConsume.Text,
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

        private void btnGetByNumber_Click(object sender, EventArgs e)
        {
            var result = _service.BuscarPorCodigo(txtCode.Text);
            if (result != null)
            {
                txtId.Text = result.Id.ToString();
                txtName.Text = result.Nombre;
                txtCode.Text = result.Codigo;
                txtEnglishName.Text = result.NomIdioma;
                txtType.Text = result.Tipo.ToString();
                txtIs.Text = result.EsBaja.ToString();
                txtMAccount.Text = result.CtaMayor.ToString();
                dtStartDate.Value = result.FechaAlta;
                txtSistOrigin.Text = result.SistOrigen.ToString();
                txtCurrency.Text = result.Moneda.ToString();
                txtGroupDigit.Text = result.DigitoAgrupador.ToString();
                txtAcceptSegment.Text = result.AplicaSegNeg.ToString();
                txtCodAccountSum.Text = result.CodigoCuentaAcumula;
                txtDig1.Text = result.DigitoFiscal1.ToString();
                txtDig2.Text = result.DigitoFiscal2.ToString();
                txtSatGroup.Text = result.AgrupadorSAT;
                txtConsume.Text = result.Consume;
            }
            else
            {
                MessageBox.Show($"No se encontró el Concepto {txtCode.Text}.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtConsume_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtSatGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtDig2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtSistOrigin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtDig1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtCodAccountSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtGroupDigit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtIs_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtAcceptSegment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEnglishName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
