using UnityEngine;

public static class Vector3ExtensionMethods
{
    public static void SetXValue(this ref Vector3 vec, float x)
    {
        vec = new Vector3(x, vec.y, vec.z);
    }
    public static void SetYValue(this ref Vector3 vec, float y)
    {
        vec = new Vector3(vec.x, y, vec.z);
    }
    public static void SetZValue(this ref Vector3 vec, float z)
    {
        vec = new Vector3(vec.x, vec.y, z);
    }

    public static void Plus(this ref Vector3 vec, float x, float y, float z)
    {
        vec += new Vector3(x, y, z);
    }
    public static void ReverseDirection(this ref Vector3 vec)
    {
        vec = -vec;
    }
    public static void AddPerSecond(this ref Vector3 vec, Vector3 addend)
    {
        vec += addend * Time.deltaTime;
    }
    public static void AddPerSecond(this ref Vector3 vec, float x, float y, float z)
    {
        vec += new Vector3(x, y, z) * Time.deltaTime;
    }
    public static void ReScale(this ref Vector3 vec, float scaleFactor)
    {
            vec = vec * scaleFactor;
    }


}
