namespace Types.Extensions;

public static class StringExtensions
{
    static readonly int[] _validLengths = new int[] { 7, 10, 11 };

    public static bool IsValidUsPhoneNumber(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        return _validLengths.Contains(value.AlphaToNumber().Length);
    }

    public static string AlphaToNumber(this string value)
    {
        var numbers = value.ToUpperInvariant()
            .Where(char.IsAsciiLetterOrDigit)
            .Select(c => c switch
            {
                < '0' => throw new Exception(),
                <= '9' => c,
                < 'A' => throw new Exception(),
                <= 'C' => '2',
                <= 'F' => '3',
                <= 'I' => '4',
                <= 'L' => '5',
                <= 'O' => '6',
                <= 'S' => '7',
                <= 'V' => '8',
                <= 'Z' => '9',
                _ => throw new Exception()

            })
            .ToArray();

        return new string(numbers);
    }
}
