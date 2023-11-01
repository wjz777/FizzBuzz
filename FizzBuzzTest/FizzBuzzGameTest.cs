using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_the_number_given_when_countOff_given_a_normal_case_number()
        {
            //given
            int givenNumber = 1;
            //when
            string result = FizzBuzzGame.CountOff(givenNumber);

            //then
            Assert.Equal("1", result);
        }
    }
}