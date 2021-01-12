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

        //ter esquecido de trocar o virtual para override fez qua a saida só mostrasse o "com bola sabor chocolate"
        public override string BuscarCasquinha()
        {
            string casquinha = base.BuscarCasquinha();
            casquinha += "\r\n    com bola sabor baunilha";
            return casquinha;
        }
    }
}
