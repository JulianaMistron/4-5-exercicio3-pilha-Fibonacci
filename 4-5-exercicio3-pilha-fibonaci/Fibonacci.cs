
namespace _4_5_exercicio3_pilha_fibonaci
{
    internal class Fibonacci
    {
        int numero;
        Fibonacci anterior;

        public Fibonacci(int numero)
        {
            this.numero = numero;
            this.anterior = null;
        }
        public override string? ToString()
        {
            return ">>>>SEQUÊNCIA FIBONACCI: " + numero;
        }
        public void setAnterior(Fibonacci numero)
        {
            anterior = numero;
        }
        public Fibonacci getAnterior()
        {
            return anterior;
        }
        public int getValor()
        {
            return numero;
        }
    }

}