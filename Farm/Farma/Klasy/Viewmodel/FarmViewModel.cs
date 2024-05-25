using Farm.Farma.Gracz.Konto;
using Farm.Farma.Klasy.Klasy;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Farm.Farma.Klasy.Viewmodel
{
    public class FarmViewModel : ObservableObject
    {
        private PlantList _plants;

        public FarmViewModel() 
        { 
            
        }

        public ICommand PlantCommand
        { get { return new RelayCommand<Plant>(PlantExecute, CanPlantExecute()); } }
        public ICommand HarvestCommand
        { get { return new RelayCommand<Plant>(HarvestExecute, CanPlantExecute()); } }

        void PlantExecute(Plant plant)
        {
            plant.Sow();
        }

        void HarvestExecute(Plant plant, Konto CurrentFarmer)
        {
            if(plant.IsPlanted == false && plant.TimeToFarm <= 0)
            {
                plant.Harvest();
                CurrentFarmer.Coins += plant.PlantYield;
                CurrentFarmer.CurrentPlants.Remove(plant);
            }

        }

        bool CanPlantExecute()
        {
            if(CurrentFarmer == null) return false;
            if(_plants == null) return false;
            return true;
        }

    }
}
