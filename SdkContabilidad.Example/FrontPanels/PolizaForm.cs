using SdkContabilidad.Integrator.Common;
using SdkContabilidad.Integrator.Schemas;
using SdkContabilidad.Integrator.Services;
using System;
using System.Windows.Forms;

namespace SdkContabilidad.Example.FrontPanels
{
    public partial class PolizaForm : Form
    {
        private readonly PolizaService _service;

        public PolizaForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _service = new PolizaService();
        }

        private void btnGetBySystem_Click(object sender, EventArgs e)
        {
            var result = _service.BuscarTodosPorSistOrigenRango();

            dgResult.DataSource = null;
            dgResult.DataSource = result;
        }

        private void btnGetByYearPeriod_Click(object sender, EventArgs e)
        {
            var result = _service.BuscarTodasPorEjercicioPeriodoTipoNumero();

            dgResult.DataSource = null;
            dgResult.DataSource = result;
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtId.Text, out number))
            {
                var result = _service.BuscaPorId(txtId.Text.ToInt());
                if (result != null)
                {
                    txtNumero.Text = result.Numero.ToString();
                    txtNumMovement.Text = result.NumeroMovtos.ToString();
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PolizaDto cuentaDto = new PolizaDto
            {
                Abonos = txtAbonos.Text.ToDecimal(),
                Ajuste = txtAdjust.Text.ToInt(),
                Cargos = txtCharges.Text.ToDecimal(),
                Clase = txtClass.Text.ToInt(),
                CodigoDiario = txtCodeDiary.Text,
                Concepto = txtConcept.Text,
                Diario = txtDiary.Text.ToInt(),
                Ejercicio = txtYear.Text.ToInt(),
                Guid = txtMGuid.Text,
                Id = txtId.Text.ToInt(),
                Numero = txtNumero.Text.ToInt(),
                NumeroMovtos = txtNumMovement.Text.ToInt(),
                Periodo = txtPeriod.Text.ToInt(),
                SistOrigen = txtOrigenSys.Text.ToInt(),
                Tipo = txtTipo.Text.ToInt(),
                Usuario = txtUser.Text
            };

            var result = _service.Crear(cuentaDto);

            if (result == 0)
            {
                MessageBox.Show($"No se pudo crear la Póliza {txtYear}-{txtPeriod}.");
            }
            else
            {
                MessageBox.Show($"Póliza creado correctamente.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = txtId.Text.ToInt();

            var result = _service.Borrar(id);

            if (result)
            {
                MessageBox.Show($"Póliza {id} borrada correctamente.");
            }
            else
            {
                MessageBox.Show($"Póliza borrada correctamente.");
            }
        }

        private void btnAddMovement_Click(object sender, EventArgs e)
        {
            MovimientoPolizaDto cuentaDto = new MovimientoPolizaDto
            {
                CodigoCuenta = txtMCodAccount.Text,
                IdCuenta = txtMIdCuenta.Text.ToInt(),
                IdDiario = txtMIdDiario.Text.ToInt(),
                IdPoliza = txtPId.Text.ToInt(),
                IdSegNeg = txtMIdSegNeg.Text.ToInt(),
                Importe = txtMAmmountMe.Text.ToDecimal(),
                ImporteME = txtMAmmountMe.Text.ToDecimal(),
                CodigoDiario = txtCodeDiary.Text,
                Concepto = txtMConcept.Text,
                Diario = txtMDiary.Text.ToInt(),
                Guid = txtMGuid.Text,
                Id = txtMId.Text.ToInt(),
                NumMovto = txtNumMovement.Text.ToInt(),
                Referencia = txtMReference.Text,
                SegmentoNegocio = txtMSegment.Text,
                TipoMovto = txtMType.Text.ToInt()
            };

            var result = _service.AgregaMovimientoPoliza(cuentaDto);

            if (result == 0)
            {
                MessageBox.Show($"No se pudo agregar el Movimiento para la póliza {txtPId}.");
            }
            else
            {
                MessageBox.Show($"Movimiento agregado correctamente.");
            }
        }
    }
}
