namespace TestRomanConverter
{
    public class RomanConverterTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        [InlineData(21, "XXI")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        public void ConvertToRoman_ValidNumber_ReturnsCorrectRomanNumeral(int number, string expectedRomanNumeral)
        {
            string result = RomanConverter.ConvertToRoman(number);

            Assert.Equal(expectedRomanNumeral, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4000)]
        [InlineData(-10)]
        public void ConvertToRoman_InvalidNumber_ThrowsException(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => RomanConverter.ConvertToRoman(number));
        }

    }
}