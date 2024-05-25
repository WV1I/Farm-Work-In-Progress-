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
        public ShopViewModel(PlantList Plants) 
        { 
        
        }
        public Konto CurrentShopUser { get; set; }

        private int _coins;
        private PlantList _plants;
        
        public int Coins { get { return _coins; } set { _coins = value; RaisePropertyChanged("Coins"); } }


        public ICommand BuyCommand
        { get { return new RelayCommand<Plant>(BuyExecute, CanSellExecute()); } }
        public ICommand SellCommand
        { get { return new RelayCommand<Plant>(SellExecute, CanSellExecute()); } }

        void BuyExecute(Plant plant)
        {
            CurrentShopUser.Coins -= plant.Price;
            CurrentShopUser.CurrentPlants.Add(plant);
        }
        void SellExecute(Plant plant)
        {
            CurrentShopUser.Coins += plant.Price;
            CurrentShopUser.CurrentPlants.Remove(plant);
        }
        bool CanBuyExecute(Plant Plant)
        {
            if(CurrentShopUser.Coins >= Plant.Price)
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
