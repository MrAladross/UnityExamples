using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public static class ObjectExtensionMethods
{
    public static byte[] ObjectToBytes(this object obj)
    {
        BinaryFormatter bf = new BinaryFormatter();
        using (var ms = new MemoryStream())
        {
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }
    }
}
