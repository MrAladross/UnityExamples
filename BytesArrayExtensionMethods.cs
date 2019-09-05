using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class BytesArrayExtensionMethods 
{
    public static object BytesToObject(this byte[] bytes)
    {
        using (var memStream = new MemoryStream())
        {
            var binForm = new BinaryFormatter();
            memStream.Write(bytes, 0, bytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            var obj = binForm.Deserialize(memStream);
            return obj;
        }
    }

    public static int GetUsedBytes(this byte[] bytes)
    {
        int recv = 0;
        foreach (byte b in bytes)
        {
            if (b != 0)
            {
                recv++;
            }
        }
        return recv;
    }
}
