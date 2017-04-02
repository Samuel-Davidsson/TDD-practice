using FibonacciDomain;
using Xunit;


namespace FibonacciTests
{
    public class FibonacciTests
    {
        [Fact]
        public void Fib_Given0_Return0()
        {
            //arrange
            int n = 0;
            //act
            int result = Fibonacci.Fib(n);
            //assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void Fib_Given1_Return1()
        {
            //arrange
            int n = 1;
            //act
            int result = Fibonacci.Fib(n);
            //assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void Fib_Given2_Return1()
        {
            //arrange
            int n = 2;
            //act
            int result = Fibonacci.Fib(n);
            //assert
            Assert.Equal(1, result);        
        }
        [Fact]
        public void Fib_Given3_Return2()
        {
            //arrange
            int n = 3;
            //act
            int result = Fibonacci.Fib(n);
            //assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void Fib_Given4_Return3()
        {
            //arrange
            int n = 4;
            //act
            int result = Fibonacci.Fib(n);
            //assert
            Assert.Equal(3, result);
        }
        [Fact]
        public void Fib_Given11_Return89()
        {
            //arrange
            int n = 11;
            //act
            int result = Fibonacci.Fib(n);
            //assert
            Assert.Equal(89, result);
        }
    }
}
