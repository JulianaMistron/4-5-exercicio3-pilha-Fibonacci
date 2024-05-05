using _4_5_exercicio3_pilha_fibonaci;

internal class PilhaFibonacci
{
    Fibonacci topo;
    public PilhaFibonacci()
    {
        topo = null;
    }

    public void GerarSequencia(int posicao)
    {
        int primeiroNumero = 1;
        int proximoNumero = 0;

        for (int i = 0; i < posicao; i++)
        {
            Fibonacci aux = new Fibonacci(primeiroNumero);

            this.push(aux);
            primeiroNumero = primeiroNumero + proximoNumero;
            proximoNumero = primeiroNumero - proximoNumero;
        }
    }

    public void push(Fibonacci aux)
    {
        if (vazia() == true)
            topo = aux;
        else
        {
            aux.setAnterior(topo);
            topo = aux;
        }
    }
    bool vazia()
    {
        if (topo == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void print()
    {
        Fibonacci aux = topo;
        if (vazia())
        {
            Console.WriteLine("Pilha vazia!");
            Console.WriteLine("Presione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        else
        {
            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.getAnterior();
            } while (aux != null);

            Console.WriteLine("Fim da impressão!");
            Console.WriteLine("Presione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}