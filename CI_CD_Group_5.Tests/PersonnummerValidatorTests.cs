using Xunit;
using PersonnummerKontroll;

namespace CI_CD_Group_5.Tests
{
    public class PersonnummerTests
    {
        [Fact]
        public void Validate_ValidPersonnummer_ReturnsTrue()
        {
            string input = "19811218-9876";

            var result = PersonnummerValidator.Validate(input);

            Assert.True(result.IsValid);
        }
    }
}