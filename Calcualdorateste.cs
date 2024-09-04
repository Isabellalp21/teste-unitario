using Xunit;

namespace projetoxunit

{
    public class Calcualdorateste
    {
        [Fact]
        public void TesteSomar()
        {
            double resultado = Calculadora.Somar(10, 3);
            Assert.Equal(13, resultado);
        }
        [Fact]
        public void TesteSubtrair()
        {
            double resultado = Calculadora.Subtrair(10, 8);
            Assert.Equal(2, resultado);
        }
        [Fact]
        public void TesteMultiplicar()
        {
            double resultado = Calculadora.Multiplicar(2, 2);
            Assert.Equal(4, resultado);
        }
        [Fact]
        public void TesteDividir()
        {
            double resultado = Calculadora.Dividir(10, 2);
            Assert.Equal(5, resultado);
        }
        [Fact]
        public void TesteDividirPorZero()
        {
            double resultado = Calculadora.DividirPorZero(10,0);
            Assert.Equal(double.PositiveInfinity, resultado);
        }

    }
}