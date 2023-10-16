using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImplementacao _calc;


    public CalculadoraTestes()
    {
        _calc = new CalculadoraImplementacao();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act

        int resultado = _calc.Somar(num1,num2);

        //Assert 

        Assert.Equal(15,resultado);

    }


    [Fact]
    public void VerificarSe4EParERetornarVerdadeiro()
    {
       //Arrange

       int numero = 4;

       // Act

       bool resultado = _calc.EhPar(numero);


       //Assert

       Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2,4})]
    [InlineData(new int[] {6,8,10})]
    
    public void VerifiicarSeNumerosEParERetornarVerdadeiro(int[] numeros)
    {
       // Act / Assert
       Assert.All(numeros,num => Assert.True(_calc.EhPar(num)))


      
    }
}