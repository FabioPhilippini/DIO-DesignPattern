using DecoratorExemplo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExemplo
{
    public class Casquinha : ICasquinha
    {
        public string BuscarCasquinha()
        {
            var casquinha = "Esta é uma casquinha";
            return casquinha;
        }
    }
}
