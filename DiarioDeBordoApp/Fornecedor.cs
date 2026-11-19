using System;

namespace DiarioDeBordoApp
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Fornecedor(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}