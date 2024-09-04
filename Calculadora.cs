
namespace projetoxunit
{
    public static class Calculadora
    {
        public static double Somar(double x, double y)
        {
            return x + y;
        }
        public static double Subtrair(double x, double y)
        {
            return x - y;
        }
        public static double Multiplicar(double x, double y)
        {
            return x * y;
        }
        public static double Dividir(double x, double y)
        {
            return x / y;
        }
        public static double DividirPorZero(double numerador, double denominador)
        {
            return numerador / denominador;
        }
    }
}
