using SdkContabilidad.Example.FrontPanels;
using SdkContabilidad.Integrator.Common;
using SdkContabilidad.Integrator.Schemas;
using SdkContabilidad.Integrator.Services;
using SDKCONTPAQNGLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SdkContabilidad.Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SessionService.Instance.IniciarConexion();

            if(!SessionService.Instance.ConexionInciada)
            {
                MessageBox.Show("Error", "No fue posible iniciar la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SessionService.Instance.IniciarSesionUsuario(txtUser.Text, txtPassword.Text);

            if (!SessionService.Instance.SesionUsuarioIniciada)
            {
                MessageBox.Show("Error", "No fue posible iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            SessionService.Instance.TerminarConexion();
        }

        private void btnOpenCompany_Click(object sender, EventArgs e)
        {
            SessionService.Instance.AbrirEmpresa(txtCompany.Text);
        }

        private void btnCloseCompany_Click(object sender, EventArgs e)
        {
            SessionService.Instance.CierraEmpresa();
        }

        private void btnConcepts_Click(object sender, EventArgs e)
        {
            try{
                ConceptForm form = new ConceptForm();
                form.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                AccountForm form = new AccountForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            try
            {
                ClientForm form = new ClientForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PolizaForm form = new PolizaForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
