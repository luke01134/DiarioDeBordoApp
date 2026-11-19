using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiarioDeBordoApp
{
    // Herda de Registro (Classe Filha)
    public class Customizacao : Registro
    {
        // Atributo específico da Customização
        public string MarcaDaPeca { get; set; }

        // Construtor usando 'base' para inicializar os atributos da mãe
        public Customizacao(DateTime data, string descricao, decimal custo, int quilometragemNoDia, Fornecedor fornecedor, string marcaDaPeca)
            : base(data, descricao, custo, quilometragemNoDia, fornecedor)
        {
            MarcaDaPeca = marcaDaPeca;
        }

        // Polimorfismo: Adapta o resumo para exibir a marca da peça customizada
        public override string ObterResumo()
        {
            string nomeFornecedor = Fornecedor != null ? Fornecedor.Nome : "N/A";
            return $"[CUSTOMIZAÇÃO] {Data.ToShortDateString()} - {Descricao} ({MarcaDaPeca}) | R$ {Custo:F2} | Local: {nomeFornecedor}";
        }
    }
}