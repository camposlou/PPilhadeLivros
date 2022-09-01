using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilhadeLivros
{
    internal class PilhaLivros
    {
        public Livro Topo { get; set; }

        public PilhaLivros()
        {
            Topo = null;
            Console.WriteLine("Pilha criada com sucesso!\n");
        }
        public void Push(Livro aux)
        {
            if (Vazia())
                Topo = aux;

            else
            {
                aux.Anterior = Topo;
                Topo = aux;
            }

        }
        public void Print()
        {
            if (Vazia())
                Console.WriteLine("Pilha Vazia!");
            else
            {
                Livro aux = Topo;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine("\nFIM DA IMPRESSÃO!");

            }
        }
        public void AcharTitulo(string titulo)
        {
            if (Vazia())
                Console.WriteLine("Pilha Vazia!");
            else
            {
                Livro aux = Topo;
                bool achou = false;
                do
                {
                    if (aux.Titulo.Equals (titulo))
                    {
                        Console.WriteLine("Livro Localizado:");
                        Console.WriteLine(aux.ToString());
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        achou = true;
                    }
                    aux = aux.Anterior;

                } while (aux != null);
                if (!achou)
                    Console.WriteLine("Livro não localizado com esse titulo: " + titulo);
                else
                    Console.WriteLine("Fim da Busca");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        public int Length()
        {
            if (Vazia())
                return 0;
            else
            {
                Livro aux = Topo;
                int qtd = 0;
                do
                {
                    qtd++;
                    aux = aux.Anterior;

                } while (aux != null);
                return qtd;
            }
        }

        public void Pop()
        {
            if (Vazia())
                Console.WriteLine("Pilha Vazia! Impossivel Remover");
            else
            {
                Topo = Topo.Anterior;
            }
        }

        private bool Vazia()
        {
            if (Topo == null)
                return true;
            else
                return false;
        }

    }

}



