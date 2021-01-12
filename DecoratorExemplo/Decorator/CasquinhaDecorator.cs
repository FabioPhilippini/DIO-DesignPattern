using DecoratorExemplo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExemplo.Decorator
{
    public class CasquinhaDecorator
    {
        private readonly ICasquinha _casquinha;

        public CasquinhaDecorator(ICasquinha casquinha)
        {
            _casquinha = casquinha;
        }
        public virtual string BuscarCasquinha()
        {
            var casquinha = _casquinha.BuscarCasquinha();
            return casquinha;
        }
    }
}
