//faça um programa coloque os n valores da sequencia fibonacci em uma pilha(fala qtos numeros quer guardar,
//e guarda na pilha)

using _4_5_exercicio3_pilha_fibonaci;

PilhaFibonacci pilhaFibonacci = new PilhaFibonacci();
Console.WriteLine("Informe a posição da sequência Fibonacci que você deseja gerar: ");
int posicao = int.Parse(Console.ReadLine());
pilhaFibonacci.GerarSequencia(posicao);


Console.WriteLine("\nNúmeros da sequência Fibonacci armazenados na pilha:");
pilhaFibonacci.print();





