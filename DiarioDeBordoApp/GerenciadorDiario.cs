using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiarioDeBordoApp
{
    public class GerenciadorDiario
    {
        // Atributos de Gestão
        public Motocicleta Moto { get; set; }
        public List<Registro> ListaRegistros { get; set; }

        // Eventos para Programação Orientada a Eventos (POE)
        public event EventHandler RegistroAdicionado;
        public event EventHandler<string> AlertaManutencao;

        // Construtor
        public GerenciadorDiario(Motocicleta moto)
        {
            Moto = moto;
            ListaRegistros = new List<Registro>();
        }

        // Método principal para adicionar um registo na lista
        public void AdicionarRegistro(Registro novoRegistro)
        {
            ListaRegistros.Add(novoRegistro);

            // Atualiza a quilometragem atual da moto com base no registo feito
            if (novoRegistro.QuilometragemNoDia > Moto.QuilometragemAtual)
            {
                Moto.AtualizarQuilometragem(novoRegistro.QuilometragemNoDia);
            }

            // Dispara o evento de que um registo foi adicionado com sucesso
            RegistroAdicionado?.Invoke(this, EventArgs.Empty);

            // Verifica se é uma manutenção e se passou do limite para disparar o alerta
            if (novoRegistro is Manutencao manutencao)
            {
                if (manutencao.PrecisaManutencao(Moto.QuilometragemAtual))
                {
                    string mensagem = $"Atenção! A mota {Moto.Modelo} atingiu ou passou a quilometragem para a próxima troca ({manutencao.KmProximaTroca} km)!";
                    AlertaManutencao?.Invoke(this, mensagem);
                }
            }
        }
    }
}