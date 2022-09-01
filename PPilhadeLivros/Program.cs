using System;

namespace PPilhadeLivros
{
    internal class Program
    {
       
        static void Menu()
        {
            PilhaLivros minhapilha = new();
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine(">>> MENU <<<");
                Console.WriteLine("1 - Inserir Livro na Pilha");
                Console.WriteLine("2 - Remover Livro da Pilha");
                Console.WriteLine("3 - Imprimir a Pilha");
                Console.WriteLine("4 - Imprimir a quantidade de Livros na Pilha");
                Console.WriteLine("5 - Localizar um Livro na Pilha");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        minhapilha.Push(Ler_Livro()); 
                        break;
                    case 2:
                        minhapilha.Pop();
                        
                        break;
                    case 3:
                        minhapilha.Print();
                        break;
                    case 4:
                        Console.WriteLine("A pilha possui {0} elemento(s): ", minhapilha.Length());
                        break;
                    case 5:
                        string titulo;
                        Console.WriteLine("Informe o titulo do Livro que deseja localizar: ");
                        titulo = Console.ReadLine();
                        minhapilha.AcharTitulo(titulo);
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opc != 0);
            Console.WriteLine(">>> FIM <<<");
        }
        private static Livro Ler_Livro()
        {
            Console.Clear();
            Console.WriteLine("CADASTRO DO LIVRO: ");
            Console.WriteLine("Digite o Titulo do Livro: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o ISBN do Livro: ");
            int isbn = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Autor do Livro: ");
            string autor = Console.ReadLine();

            return new Livro(titulo, isbn, autor);

        }

        static void Main(string[] args)
        {

            Menu();
        }
    }
}