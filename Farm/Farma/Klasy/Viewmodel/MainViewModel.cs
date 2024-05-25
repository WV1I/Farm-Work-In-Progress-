using Farm.Farma.Gracz.Konto;
using Farm.Farma.Klasy.Klasy;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm.Farma.Klasy.Viewmodel
{
    public class MainViewModel : ObservableObject
    {
        public AccountList AccountList { get; set; }
        public PlantList Plants { get; set; }
        public LoginViewModel LoginViewModel { get; set; }
        public Konto CurrentUser { get { return LoginViewModel.CurrentUser; } set { LoginViewModel.CurrentUser = value; FarmViewModel.CurrentFarmer = value; } }
        public FarmViewModel FarmViewModel { get; set; }

        public MainViewModel()
        {
            AccountList = new AccountList();
            Plants = new PlantList();
            LoginViewModel = new LoginViewModel(AccountList);
            FarmViewModel = new FarmViewModel();

        }
    }
}
