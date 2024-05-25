using Farm.Farma.Gracz.Konto;
using Farm.Farma.Klasy.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Farm.Farma.Okna
{
    /// <summary>
    /// Logika interakcji dla klasy MainGame.xaml
    /// </summary>
    public partial class MainGame : Window
    {
        public MainGame(Konto Account)
        {
            MainViewModel viewModel = new MainViewModel();
            viewModel.LoginViewModel.CurrentUser = Account;
            this.DataContext = viewModel;
            if (viewModel.LoginViewModel.CloseWindow == null) 
            {
                viewModel.LoginViewModel.CloseWindow = new Action(Close);
            }
            
            InitializeComponent();
            

        }
    }
}
