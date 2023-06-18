using System;
using System.Text;


public class RomanConverter
{
    public static void Main(string[] args)
    {
    }

    public static string ConvertToRoman(int number)
    {
        if (number < 1 || number > 3999)
            throw new ArgumentOutOfRangeException("Number must be between 1 and 3999.");

        string[] romanNumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] arabicValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        StringBuilder romanRepresentation = new StringBuilder();

        for (int i = 0; i < romanNumerals.Length; i++)
        {
            // While the current Arabic value can be subtracted from the number
            while (number >= arabicValues[i])
            {
                // Append the corresponding Roman numeral to the representation
                romanRepresentation.Append(romanNumerals[i]);

                // Subtract the Arabic value from the number
                number -= arabicValues[i];
            }
        }

        return romanRepresentation.ToString();
    }
}
