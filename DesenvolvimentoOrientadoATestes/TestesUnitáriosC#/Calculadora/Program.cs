using Calculadora.Services;

CalculadoraImplementacao c = new CalculadoraImplementacao();

int num1 =20;
int num2 = 30;

System.Console.WriteLine($"{num1} + {num2} = {c.Somar(num1,num2)}");