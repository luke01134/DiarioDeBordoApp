using System;

namespace DiarioDeBordoApp
{
    public class Registro
    {
        // Atributos base
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Custo { get; set; }
        public int QuilometragemNoDia { get; set; }

        // Associação com a nova classe Fornecedor
        public Fornecedor Fornecedor { get; set; }

        // Construtor atualizado
        public Registro(DateTime data, string descricao, decimal custo, int quilometragemNoDia, Fornecedor fornecedor)
        {
            Data = data;
            Descricao = descricao;
            Custo = custo;
            QuilometragemNoDia = quilometragemNoDia;
            Fornecedor = fornecedor;
        }

        // Método virtual para polimorfismo
        public virtual string ObterResumo()
        {
            string nomeFornecedor = Fornecedor != null ? Fornecedor.Nome : "N/A";
            return $"{Data.ToShortDateString()} - {Descricao} | R$ {Custo:F2} | Local: {nomeFornecedor}";
        }
    }
}