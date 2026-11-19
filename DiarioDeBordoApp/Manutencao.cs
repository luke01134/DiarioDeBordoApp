using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDeBordoApp
{
    // O ':' significa que Manutencao herda de Registro (Classe Filha)
    public class Manutencao : Registro
    {
        // Atributo específico da Manutenção
        public int KmProximaTroca { get; set; }

        // Construtor: Repassa os dados comuns para a mãe usando a palavra 'base'
        public Manutencao(DateTime data, string descricao, decimal custo, int quilometragemNoDia, Fornecedor fornecedor, int kmProximaTroca)
            : base(data, descricao, custo, quilometragemNoDia, fornecedor)
        {
            KmProximaTroca = kmProximaTroca;
        }

        // Método específico da manutenção (o que desenhou no Astah)
        public bool PrecisaManutencao(int kmAtual)
        {
            return kmAtual >= KmProximaTroca;
        }

        // Polimorfismo: Modifica o método herdado da mãe para exibir detalhes de manutenção
        public override string ObterResumo()
        {
            string nomeFornecedor = Fornecedor != null ? Fornecedor.Nome : "N/A";
            return $"[MANUTENÇÃO] {Data.ToShortDateString()} - {Descricao} | R$ {Custo:F2} | Próx. Troca: {KmProximaTroca} km | Local: {nomeFornecedor}";
        }
    }
}
