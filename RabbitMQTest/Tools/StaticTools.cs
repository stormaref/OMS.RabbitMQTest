using RabbitMQTest.Models;
using RabbitMQTest.Models.Messages;

namespace RabbitMQTest.Tools;

public static class StaticTools
{
    public static long ToLong(this Amount amount)
    {
        return amount.IFt.ToLong();
    }

    public static long ToLong(this string amount)
    {
        if (int.TryParse(amount.Trim(), out var number) && number != 0)
        {
            throw new Exception();
        }

        return long.Parse(amount.Trim());
    }

    public static DateTime GetDateTime(this RlcDiffHeader header)
    {
        var dEven = header.DEven;
        var hEven = header.HEven;
        var year = int.Parse(dEven.Substring(0, 4));
        var month = int.Parse(dEven.Substring(4, 2));
        var day = int.Parse(dEven.Substring(6, 2));
        var hour = int.Parse(hEven.Substring(0, 2));
        var minute = int.Parse(hEven.Substring(2, 2));
        var second = int.Parse(hEven.Substring(4, 2));
        return new DateTime(year, month, day, hour, minute, second);
    }

    #region Double

    public static double ConvertToDouble(this Amount amount)
    {
        var ift = amount.IFt.Trim();
        var qmt = amount.QMt;
        return ConvertToDouble(ift, qmt);
    }

    private static double ConvertToDouble(string ift, string qmt)
    {
        if (!int.TryParse(ift, out var number)) return ConvertCharToDouble(ift, qmt);
        if (number > 0) qmt = qmt.Insert(qmt.Length - number, ".");

        return double.Parse(qmt);
    }

    private static double ConvertCharToDouble(string ift, string qmt)
    {
        if (string.IsNullOrWhiteSpace(ift)) return double.Parse(qmt);

        return ift.ToLower() switch
        {
            "a" => -1 * ConvertToDouble("0", qmt),
            "b" => -1 * ConvertToDouble("1", qmt),
            "c" => -1 * ConvertToDouble("2", qmt),
            "d" => -1 * ConvertToDouble("3", qmt),
            "e" => -1 * ConvertToDouble("4", qmt),
            "f" => -1 * ConvertToDouble("5", qmt),
            "g" => -1 * ConvertToDouble("6", qmt),
            "h" => -1 * ConvertToDouble("7", qmt),
            "i" => -1 * ConvertToDouble("8", qmt),
            "j" => -1 * ConvertToDouble("9", qmt),
            _ => throw new NotImplementedException()
        };
    }

    #endregion

    #region Float

    public static double ConvertToFloat(this Amount amount)
    {
        var ift = amount.IFt.Trim();
        var qmt = amount.QMt;
        return ConvertToFloat(ift, qmt);
    }

    private static double ConvertToFloat(string ift, string qmt)
    {
        if (!int.TryParse(ift, out var number)) return ConvertCharToDouble(ift, qmt);
        if (number > 0) qmt = qmt.Insert(qmt.Length - number, ".");

        return float.Parse(qmt);
    }

    private static double ConvertCharToFloat(string ift, string qmt)
    {
        if (string.IsNullOrWhiteSpace(ift)) return float.Parse(qmt);

        return ift.ToLower() switch
        {
            "a" => -1 * ConvertToFloat("0", qmt),
            "b" => -1 * ConvertToFloat("1", qmt),
            "c" => -1 * ConvertToFloat("2", qmt),
            "d" => -1 * ConvertToFloat("3", qmt),
            "e" => -1 * ConvertToFloat("4", qmt),
            "f" => -1 * ConvertToFloat("5", qmt),
            "g" => -1 * ConvertToFloat("6", qmt),
            "h" => -1 * ConvertToFloat("7", qmt),
            "i" => -1 * ConvertToFloat("8", qmt),
            "j" => -1 * ConvertToFloat("9", qmt),
            _ => throw new NotImplementedException()
        };
    }

    #endregion

    #region Decimal

    public static double ConvertToDecimal(this Amount amount)
    {
        var ift = amount.IFt.Trim();
        var qmt = amount.QMt;
        return ConvertToFloat(ift, qmt);
    }

    private static double ConvertToDecimal(string ift, string qmt)
    {
        if (!int.TryParse(ift, out var number)) return ConvertCharToDouble(ift, qmt);
        if (number > 0) qmt = qmt.Insert(qmt.Length - number, ".");

        return float.Parse(qmt);
    }

    private static double ConvertCharToDecimal(string ift, string qmt)
    {
        if (string.IsNullOrWhiteSpace(ift)) return float.Parse(qmt);

        return ift.ToLower() switch
        {
            "a" => -1 * ConvertToDecimal("0", qmt),
            "b" => -1 * ConvertToDecimal("1", qmt),
            "c" => -1 * ConvertToDecimal("2", qmt),
            "d" => -1 * ConvertToDecimal("3", qmt),
            "e" => -1 * ConvertToDecimal("4", qmt),
            "f" => -1 * ConvertToDecimal("5", qmt),
            "g" => -1 * ConvertToDecimal("6", qmt),
            "h" => -1 * ConvertToDecimal("7", qmt),
            "i" => -1 * ConvertToDecimal("8", qmt),
            "j" => -1 * ConvertToDecimal("9", qmt),
            _ => throw new NotImplementedException()
        };
    }

    #endregion
}