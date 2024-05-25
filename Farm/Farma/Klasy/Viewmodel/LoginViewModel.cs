using Farm.Farma.Gracz.Konto;
using Farm.Farma.Okna;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Farm.Farma.Klasy.Viewmodel
{
    public class LoginViewModel : ObservableObject
    {
        private string _username;
        private AccountList Konta = new AccountList();
        public Action CloseWindow { get; set; }
        public Konto CurrentUser { get { return currentuser; } set { currentuser = value; RaisePropertyChanged("CurrentUser"); } }
        private Konto currentuser;
        public bool IsLogged { get { return islogged; } set { islogged = value; RaisePropertyChanged("IsLogged"); } }
        private bool islogged;
        private string loginmessage;
        public string LoginMessage { get { return loginmessage;  } set { loginmessage = value; RaisePropertyChanged("LoginMessage"); } }

        public string Username { get { return _username; } set { _username = value; RaisePropertyChanged("Username"); } }

        public LoginViewModel(AccountList Konta) 
        { 
            this.Konta = Konta;
        }
        public LoginViewModel()
        {

        }
        public ICommand LoginCommand
        { get { return new RelayCommand<PasswordBox>(LoginExecute, CanLoginExecute()); } }
        public ICommand RegisterCommand
        { get { return new RelayCommand<PasswordBox>(RegisterExecute, CanLoginExecute()); } }
        public ICommand LogOutCommand
        { get { return new RelayCommand(LogOutExecute, canLogOut); } }

        private void LogOutExecute()
        {
            IsLogged = false;
            currentuser = null;
        }

        private bool CanLoginExecute()
        {
            return !string.IsNullOrEmpty(_username);
        }
        bool canLogOut()
        {
            if (currentuser != null && IsLogged == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void RegisterExecute(PasswordBox passwordBox)
        {
            string value = passwordBox.Password;
            if (!CanLoginExecute()) return;
            if(string.IsNullOrEmpty(value)) 
            {
                LoginMessage = "Proszę podać hasło";
                return;
            }
            if(Konta.GetKonto(_username) == null)
            {
                Konta.Add(new Konto(_username, value));
                Konta.GetKonto(_username).Coins = 100;
                LoginMessage = "Pomyślnie Zarejestrowano Konto: " + _username;
            }
            else
            {
                LoginMessage = "Konto: " + _username + " już istnieje";
            }


        }
        void LoginExecute(PasswordBox passwordBox)
        {
            string value = passwordBox.Password;
            if (!CanLoginExecute()) return;
            
            if(Konta.ValidateAccount(_username, value))
            {
                CurrentUser = Konta.GetKonto(_username);
                CurrentUser.CurrentPlants.Add(new Klasy.Plant("TESTPomidor", 5, 20));
                CurrentUser.CurrentPlants.Add(new Klasy.Plant("TESTWinogrono", 5, 25));
                CurrentUser.CurrentPlants.Add(new Klasy.Plant("TESTPieczarka", 5, 25));
                CurrentUser.CurrentPlants.Add(new Klasy.Plant("TESTP", 5, 25));
                
                LoginMessage = "";
                IsLogged = true;
            }
            else
            {
                LoginMessage = "Nieprawidłowa Nazwa Użytkownika lub Hasło";
            }
        }
        
    }
}
