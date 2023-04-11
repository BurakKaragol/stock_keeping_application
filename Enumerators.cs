using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ExtensionMethods
{
    public static bool NullOrEmpty(this string str)
    {
        return str == "" || str == null;
    }

    public static bool NullOrAsterisk(this string str)
    {
        return str == "*" || str == "" || str == null;
    }

    public static int ToInt(this string str)
    {
        try
        {
            return Convert.ToInt32(str);
        }
        catch (Exception)
        {
            return -1;
        }
    }

    public static float ToFloat(this string str)
    {
        try
        {
            float.TryParse(str, out float result);
            return result;
        }
        catch (Exception)
        {
            return -1f;
        }
    }

    public static bool IsValid(this int i)
    {
        return i >= 0;
    }

    public static bool IsValid(this float f)
    {
        return f >= 0f;
    }
}

namespace stock_keeping_application
{
    public enum ComponentType
    {
        Material,
        HalfProduct,
        Product
    }

    internal class Enumerators
    {
    }
}
