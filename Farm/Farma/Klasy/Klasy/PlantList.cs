using Farm.Farma.Gracz.Konto;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Farm.Farma.Klasy.Klasy
{
    public class PlantList : ObservableCollection<Plant>
    {
        public PlantList() : base()
        { 
            
        }
        public Plant CurrentPlant { get { return cur_plant; } set { cur_plant = value; } }
        private Plant cur_plant;
        public ICommand PlantCommand
        { get { return new RelayCommand(PlantExecute, CanPlantExecute()); } }
        public ICommand HarvestCommand
        { get { return new RelayCommand(HarvestExecute, CanPlantExecute()); } }
        public ICommand WaterPlant
        { get { return new RelayCommand(WaterPlantExecute, CanWaterPlantExecute()); } }

        private bool CanWaterPlantExecute()
        {
            return true;
        }

        private void WaterPlantExecute()
        {
            CurrentPlant.Water();
        }

        void PlantExecute()
        {
            CurrentPlant.Sow();
        }

        void HarvestExecute()
        {
            CurrentPlant.Harvest();
            this.Remove(CurrentPlant);
        }

        bool CanPlantExecute()
        {
            if(CurrentPlant != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
