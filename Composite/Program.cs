using Composite.CompositeExemplo;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var kit = new Kit(desconto: 2);

            var produto1 = new Produto(1);
            var produto2 = new Produto(2);
            var produto3 = new Produto(3);
            var produto4 = new Produto(4);

            kit.AdicionarProdutoKit(produto1);
            kit.AdicionarProdutoKit(produto2);
            kit.AdicionarProdutoKit(produto3);
            kit.AdicionarProdutoKit(produto4);

            var kit2 = new Kit(desconto: 3);

            var produto5 = new Produto(4);
            
            kit2.AdicionarProdutoKit(kit);
            kit2.AdicionarProdutoKit(produto5);


            //ARVORE

            //Kit2
            //	produto 5
            //	kit
            //		produto 1
            //		produto 2
            //		produto 3
            //		produto 4

            Console.WriteLine($"Preço Kit 2: {kit2.ObterPreco():n2}");
            Console.WriteLine($"Preço Kit 1: {kit.ObterPreco():n2}");

        }
    }
}
