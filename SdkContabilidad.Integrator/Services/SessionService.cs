using SdkContabilidad.Integrator.Common;
using SDKCONTPAQNGLib;

namespace SdkContabilidad.Integrator.Services
{
    /// <summary>
    /// Singleton SessionService, para utilizar una sola Instancia
    /// </summary>
    public sealed class SessionService
    {
        private readonly TSdkSesion _sdkSesion;

        private SessionService() 
        {
            _sdkSesion = new TSdkSesion();
        }

        public static SessionService Instance {  get { return Nested.Instance;  } }

        private class Nested
        {
            // Se especifica un constructor estático
            // para efectuar Lazy Instantiation, es decir,
            // se instancia al momento de invocación
            static Nested()
            {
            }

            internal static readonly SessionService Instance = new SessionService();
        }

        public TSdkSesion Session { get { return _sdkSesion; } }

        public bool EmpresaAbierta { get; private set; }

        public bool ConexionInciada { get; private set; }

        public bool SesionUsuarioIniciada { get; private set; }

        public void IniciarConexion()
        {
            if (_sdkSesion.conexionActiva == 0)
            {
                _sdkSesion.iniciaConexion();
            }

            if (_sdkSesion.conexionActiva == 1)
            {
                ConexionInciada = true;
            }
        }

        public void TerminarConexion()
        {
            if (ConexionInciada)
            {
                _sdkSesion.finalizaConexion();
                ConexionInciada = false;
            }
        }

        public void IniciarSesionUsuario()
        {
            _sdkSesion.firmaUsuario();

            if (_sdkSesion.ingresoUsuario == 1)
            {
                SesionUsuarioIniciada = true;
            }
        }

        public void IniciarSesionUsuario(string nombreUsuario, string contrasena)
        {
            _sdkSesion.firmaUsuarioParams(nombreUsuario, contrasena);

            if (_sdkSesion.ingresoUsuario == 1)
            {
                SesionUsuarioIniciada = true;
            }
        }

        public void AbrirEmpresa(string nombreBaseDatos)
        {
            var sdkResult = _sdkSesion.abreEmpresa(nombreBaseDatos);

            if (sdkResult == SdkResult.Success)
            {
                EmpresaAbierta = true;
            }
        }

        public void CierraEmpresa()
        {
            _sdkSesion.cierraEmpresa();

            EmpresaAbierta = false;
        }
    }
}
