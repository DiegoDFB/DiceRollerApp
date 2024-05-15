using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerApp.Models
{

    public class Dice
    {
        //Construir a modelagem de um Dado.

        public int Lados { get; set; }
        public int NumeroSorteado { get; set; }

        public Dice(int quantidadeLados)
        {
            Lados = quantidadeLados;
        }

        public void Rolar()
        {
            NumeroSorteado = new Random().Next(Lados) + 1;
        }
    }
}
