﻿using Farm.Farma.Gracz.Konto;
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
        public ICommand WaterPlant
        { get { return new RelayCommand<Plant>(WaterPlantExecute, CanWaterPlantExecute()); } }

        void PlantExecute(Plant plant)
        {
            plant.Sow();
        }

        void HarvestExecute(Plant plant)
        {
            if(plant.IsPlanted == false && plant.TimeToFarm <= 0)
            {
                plant.Harvest();
            }

        }
        private bool CanWaterPlantExecute()
        {
            return true;
        }

        private void WaterPlantExecute(Plant plant)
        {
            plant.Water();
        }
        bool CanPlantExecute()
        {
            if(_plants == null) return false;
            return true;
        }

    }
}
