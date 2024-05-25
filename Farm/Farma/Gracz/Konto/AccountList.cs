using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Farm.Farma.Gracz.Konto
{
    public class AccountList : ObservableCollection<Konto>
    {
        public AccountList() : base()
        { 
            
        }
        public void AddAccount(Konto account)
        { 
            this.Add(account);
        }
        public void AddAccount(string Username, string Password)
        {
            this.Add(new Konto(Username,Password));
        }
        
        public void RemoveAccount(Konto account) 
        { 
            this.Remove(account);
        }
        public void RemoveAccount(string Username)
        {
            for(int i = 0; i < this.Count; i++) 
            { 
                if(Username == this[i].Name)
                {
                    this.Remove(this[i]);
                }
            }
            
        }
        public Konto GetKonto(string Username)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (Username == this[i].Name)
                {
                    return this[i];
                }
            }
            return null;
        }

        public bool ValidateAccount(string Username,string Password)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (Username == this[i].Name)
                {
                    return this[i].ValidatePassword(Password);
                }
                
            }
            return false;
        }
        public void LoadList()
        {
            //Wczytanie
        }
        public void SaveList() 
        { 
            // Zapis
        }
        
    }
}
