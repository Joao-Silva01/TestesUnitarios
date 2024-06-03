using NewTalents;


namespace TestNewTalents
{
    public class CalculadoraTestes
    {

        public Calculadora ConstruirClasse() 
        {
            string data = "03/06/2024";
            Calculadora calc = new Calculadora("03/06/2024");

            return calc;
        }


        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        public void TesteSomar(int n1 , int n2, int resultado)
        {
            // Arrange
            Calculadora calc = ConstruirClasse();

            // Act
            int result = calc.Somar(n1, n2);

            // Assert
            Assert.Equal(resultado, result);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(10, 5, 5)]
        public void TesteSubtrair(int n1, int n2, int resultado)
        {
            // Arrange
            Calculadora calc = ConstruirClasse();

            // Act
            int result = calc.Subtrair(n1, n2);

            // Assert
            Assert.Equal(resultado, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int n1, int n2, int resultado)
        {
            // Arrange
            Calculadora calc = ConstruirClasse();

            // Act
            int result = calc.Multiplicar(n1, n2);

            // Assert
            Assert.Equal(resultado, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(14, 2, 7)]
        public void TesteDividir(int n1, int n2, int resultado)
        {
            // Arrange
            Calculadora calc = ConstruirClasse();

            // Act
            int result = calc.Dividir(n1, n2);

            // Assert
            Assert.Equal(resultado, result);
        }

        [Fact]
        public void TestarDivisaoPorZero() 
        {
            // Arrange
            Calculadora calc = ConstruirClasse();

            //Act e Assert
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            // Arrange
            Calculadora calc = ConstruirClasse();

            //Act
            calc.Somar(2, 3);
            calc.Somar(4, 6);
            calc.Somar(1, 5);
            calc.Somar(9, 4);

            var lista = calc.Historico();
            //Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}