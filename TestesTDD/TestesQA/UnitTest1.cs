using System;
using Xunit;
using TestesTDD;

namespace TestesQA
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void Test1(int num1,int num2,int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.somar(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
    }
}
