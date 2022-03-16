namespace SdkContabilidad.Integrator.Common
{
    public class MapperUtil
    {
        public static U Cast<T, U>(T obj)
        {
            string str = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<U>(str);
        }
    }
}
