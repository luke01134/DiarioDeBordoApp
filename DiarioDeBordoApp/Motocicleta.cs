using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DiarioDeBordoApp
{
    public class Motocicleta
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int QuilometragemAtual { get; set; }

        public Motocicleta(string modelo, string placa, int quilometragemAtual)
        {
            Modelo = modelo;
            Placa = placa;
            QuilometragemAtual = quilometragemAtual;
        }

        public void AtualizarQuilometragem(int novaKm)
        {
            if (novaKm > QuilometragemAtual)
            {
                QuilometragemAtual = novaKm;
            }
        }
    }
}