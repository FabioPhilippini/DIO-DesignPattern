using DecoratorExemplo.Decorator;
using DecoratorExemplo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExemplo.ConcreteDecorator
{
    public class BolaBaunilhaDecorator : CasquinhaDecorator
    {
        public BolaBaunilhaDecorator(ICasquinha casquinha) : base(casquinha)
        {
        }

        public virtual string BuscarCasquinha()
        {
            var casquinha = base.BuscarCasquinha();
            casquinha += "\r\n com bola sabor chocolate";
            return casquinha;
        }
    }
}
