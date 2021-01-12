using DecoratorExemplo.Decorator;
using DecoratorExemplo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExemplo.ConcreteDecorator
{
    public class BolaChocolateDecorator : CasquinhaDecorator
    {
        public BolaChocolateDecorator(ICasquinha casquinha) : base(casquinha)
        {
        }

        public override string BuscarCasquinha()
        {
            string casquinha = base.BuscarCasquinha();
            casquinha += "\r\n    com bola sabor chocolate";
            return casquinha;
        }

    }
}
