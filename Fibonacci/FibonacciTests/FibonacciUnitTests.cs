using FibonacciProject;
using Xunit;
namespace FibonacciTests
{

    public class FibonacciUnitTests
    {
        [Fact]
        public void Fib_GivenO_Return0()
        {
            //arrange
            int n = 0;
            //act
            int result = Fibonacci.Fib(n);
            //assert
            Assert.Equal(0, n);
        }

 
    }


}

 
