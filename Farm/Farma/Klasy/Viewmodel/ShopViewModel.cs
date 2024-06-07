using Farm.Farma.Gracz.Konto;
using Farm.Farma.Klasy.Klasy;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Farm.Farma.Klasy.Viewmodel
{
    public class ShopViewModel : ObservableObject
    {

        public Konto CurrentShopUser { get; set; }

        private int _coins;
        public PlantList PlantsForSale { get; set; } 
        
        public int Coins { get { return _coins; } set { _coins = value; RaisePropertyChanged("Coins"); } }

        public ShopViewModel(Konto CurrentUser)
        {
            CurrentShopUser = CurrentUser;
            PlantsForSale = new PlantList();
            PlantsForSale.Add(new Plant("Pomidor", 40, 20));
            PlantsForSale.Add(new Plant("Arbuz", 200, 60));
            PlantsForSale.Add(new Plant("Banan", 70, 40));
            PlantsForSale.Add(new Plant("Winogrona", 100, 70));
        }
        public ICommand BuyCommand
        { get { return new RelayCommand<Plant>(BuyExecute, CanBuyExecute()); } }
        void BuyExecute(Plant plant)
        {
            if(CurrentShopUser.Coins >= plant.Price)
            {
                var tempPlant = new Plant(plant.PlantName, plant.Price, plant.TimeToFarm);
                CurrentShopUser.Coins -= plant.Price;
                CurrentShopUser.CurrentPlants.Add(tempPlant);
                tempPlant.Sow();
            }

        }

        bool CanBuyExecute()
        {
            if(CurrentShopUser.Coins > 0)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        bool CanSellExecute()
        {
            return true;
        }


    }
}
