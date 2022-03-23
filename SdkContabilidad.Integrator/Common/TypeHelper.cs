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

        public static decimal ToDecimal(this string value)
        {
            decimal n;

            decimal.TryParse(value, out n);

            return n;
        }
    }
}
