using Farm.Farma.Klasy.Klasy;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm.Farma.Gracz.Konto
{
    public class Konto : ObservableObject
    {
        private string name;
        private int coins;
        private string password;
        private bool isadmin;
        public string Name { get { return name; } set { name = value; RaisePropertyChanged("Name"); } }
        public int Coins { get { return coins; } set { coins = value; RaisePropertyChanged("Coins"); } }
        public bool IsAdmin { get { return isadmin; } set { isadmin = value; RaisePropertyChanged("IsAdmin"); }  }
        public PlantList CurrentPlants { get; set; } = new PlantList();

        public Konto(string Name, string Password) 
        { 
            name = Name;
            password = Password;
        }
        public Konto(bool IsAdmin) :  base()
        {
            isadmin = IsAdmin;
        }

        public bool ValidatePassword(string Password)
        {
            if(password == Password)
            {
                return true;
            }
            return false;
        }
    }
}
