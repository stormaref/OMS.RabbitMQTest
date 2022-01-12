using RabbitMQTest.Models;

namespace RabbitMQTest.Tools;

public static class StaticTools
{
    public static double ConvertToDouble(this Amount amount)
    {
        var ift = amount.IFt.Trim();
        var qmt = amount.QMt;
        return ConvertToDouble(ift, qmt);
    }

    private static double ConvertToDouble(string ift, string qmt)
    {
        if (!int.TryParse(ift, out var number)) return ConvertCharToDouble(ift, qmt);
        if (number > 0)
        {
            qmt = qmt.Insert(qmt.Length - number, ".");
        }

        return double.Parse(qmt);
    }

    private static double ConvertCharToDouble(string ift, string qmt)
    {
        if (string.IsNullOrWhiteSpace(ift))
        {
            return double.Parse(qmt);
        }

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
}