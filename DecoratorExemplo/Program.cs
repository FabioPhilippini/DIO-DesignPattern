using DecoratorExemplo.ConcreteDecorator;
using DecoratorExemplo.Interfaces;
using System;

namespace DecoratorExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICasquinha casquinha = new Casquinha();
            ICasquinha chocolateDecorator = new BolaChocolateDecorator(casquinha);
            ICasquinha baunilhaDecorator = new BolaBaunilhaDecorator(chocolateDecorator);
            ICasquinha morangoDecorator = new BolaMorangoDecorator(baunilhaDecorator);

            Console.WriteLine(morangoDecorator.BuscarCasquinha());
            Console.WriteLine();
        }
    }
}
