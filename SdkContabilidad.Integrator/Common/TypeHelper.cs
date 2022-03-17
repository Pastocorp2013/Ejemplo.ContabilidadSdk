namespace SdkContabilidad.Integrator.Common
{
    public static class TypeHelper
    {
        public static int ToInt(this string value)
        {
            int n;

            int.TryParse(value, out n);

            return n;
        }
    }
}
