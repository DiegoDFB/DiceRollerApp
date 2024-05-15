using CommunityToolkit.Mvvm.ComponentModel;
using DiceRollerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiceRollerApp.ViewModel
{
    public partial class DiceViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _quantidadeLados;

        [ObservableProperty]
        private int _numeroSorteado;

        public ICommand RolarDadoCommand { get; }

        public DiceViewModel()
        {
            RolarDadoCommand = new Command(RolarDado);
        }

        public void RolarDado()
        {
            Dice dice = new Dice(QuantidadeLados);
            dice.Rolar();
            NumeroSorteado = dice.NumeroSorteado;
        }
    }
}
