namespace TextHelper.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void MeuFact()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void MeuTheory(bool testData)
        {
            Assert.True(testData);
        }
    }
}