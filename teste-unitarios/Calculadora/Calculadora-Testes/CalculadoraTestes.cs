using Calc;

namespace Calculadora_Testes
{
    public class CalculadoraTestes
    {
        [Fact]
        public void Somar()
        {
            // Arrange
            var calculator = new Calculadora();

            // Act
            var result = calculator.Somar(5, 6);

            // Assert
            Assert.Equal(11, result);
        }

        [Fact]
        public void Subtrair()
        {
            var calculator = new Calculadora();
            var result = calculator.Subtrair(5, 5);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiplicar()
        {
            var calculator = new Calculadora();
            var result = calculator.Multiplicar(5, 4);
            Assert.Equal(20, result);
        }

        [Fact]
        public void Dividir()
        {
            var calculator = new Calculadora();
            var result = calculator.Dividir(4, 2);
            Assert.Equal(2, result);
        }
    }
}