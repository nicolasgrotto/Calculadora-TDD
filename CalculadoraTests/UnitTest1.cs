using Models.Calculadora;

namespace CalculadoraTests
{
    public class UnitTest1
    {
        private Calculadora _calc;

        public UnitTest1()
        {
            _calc = new Calculadora();
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void Somar2NumerosERetornarSeuResultadoCorreto(int val1, int val2, int resultado)
        {
            // Arrange / Act
            int resultadoSoma = _calc.Somar(val1, val2);

            // Assert
            Assert.Equal(resultado, resultadoSoma);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(5, 3, 2)]
        public void Subtrair2NumerosERetornarOResultadoCorreto(int val1, int val2, int resultado)
        {
            // Arrange / Act
            int resultadoSubtracao = _calc.Subtrair(val1, val2);

            // Assert
            Assert.Equal(resultado, resultadoSubtracao);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(5, 5, 25)]
        public void Multiplicar2NumerosERetornarOResultadoCorreto(int val1, int val2, int resultado)
        {
            // Arrange / Act
            int resultadoMultiplicacao = _calc.Multiplicar(val1, val2);

            // Assert
            Assert.Equal(resultado, resultadoMultiplicacao);
        }

        [Fact]
        public void Potencia2NumerosERetornarOResultadoCorreto()
        {
            // Arrange
            int num1 = 3;
            int num2 = 2;

            // Act
            int resultado = _calc.Potencia(num1, num2);

            // Assert
            Assert.Equal(9, resultado);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(10, 5, 2)]
        public void Dividir2NumerosERetornarOResultadoCorreto(int val1, int val2, int resultado)
        {
            // Arrange / Act
            int resultadoDivisao = _calc.Dividir(val1, val2);

            // Assert
            Assert.Equal(resultado, resultadoDivisao);
        }

        [Fact]
        public void Dividir1NumeroPor0ERetornarExcecao()
        {
            // Arrange
            int num1 = 10;
            int num2 = 0;

            // Act / Assert
            Assert.Throws<DivideByZeroException>(() => _calc.Dividir(num1, num2));
        }

        [Fact]
        public void LimparHistoricoDaCalculadora()
        {
            // Arrange
            _calc.Somar(1, 1);
            _calc.Somar(2, 2);
            _calc.Somar(3, 3);
            _calc.Somar(4, 4);

            // Act
            List<string> historico = _calc.LimparHistorico();

            // Assert
            Assert.Equal(3, historico.Count);
        }
    }
}