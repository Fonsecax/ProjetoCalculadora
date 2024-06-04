using Xunit;
using Calculadora.Services;

namespace CalculadoraTests
{
    public class UnitTest1
    {
        [Fact]
        public void Somar()
        {
            // Arrange
            CalculadoraImp calc = new CalculadoraImp();
            int num1 = 540;
            int num2 = 14;
            int resultado = num1 + num2;

            // Act
            int resultadoCalculadora = calc.Somar(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void Multiplicar()
        {
            // Arrange
            var calc = new CalculadoraImp();
            int num1 = 2;
            int num2 = 10;
            int resultadoEsperado = 2 * 10;

            // Act
            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoCalculadora);
        }

        [Fact]
        public void Subtrair()
        {
            // Arrange
            var calc = new CalculadoraImp();
            int num1 = 5;
            int num2 = 3;
            int resultadoEsperado = 5 - 3;
            // Act
            int resultadoCalculadora = calc.Subtrair(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoCalculadora);
        }

        [Fact]
        public void DividirDoisNumeros_RetornarSucesso()
        {
            // Arrange
            var calc = new CalculadoraImp();
            int num1 = 10;
            int num2 = 5;
            int resultado = 10 / 5;

            // Act
            int resultadoCalculadora = calc.Dividir(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            var calc = new CalculadoraImp();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            // Arrange
            var calc = new CalculadoraImp();

            // Act
            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);
            var lista = calc.Historico();

            // Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
