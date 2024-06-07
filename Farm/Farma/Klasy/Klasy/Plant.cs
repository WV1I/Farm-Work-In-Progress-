using Farm.Farma.Gracz.Konto;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Farm.Farma.Klasy.Klasy
{
    public class Plant : ObservableObject
    {
        private int _waterlevel;
        private string _plantname;
        private Image _icon;
        private int _timetofarm;
        private int _price;
        private bool _isplanted;
        private Brush _plantbackground;
        DispatcherTimer _farmingtimer = new DispatcherTimer();

        public int WaterLevel { get { return _waterlevel; } set { _waterlevel = value; RaisePropertyChanged("WaterLevel"); } }
        public string PlantName { get { return _plantname; } set { _plantname = value; RaisePropertyChanged("PlantName"); } }
        public Image PlantIcon { get { return _icon; } set { _icon = value; RaisePropertyChanged("PlantIcon"); } }
        public Brush PlantBackground { get { return _plantbackground; } set { _plantbackground = value; RaisePropertyChanged("PlantBackground"); } }
        public int PlantYield { get { return _plantyield; } set { _plantyield = value; RaisePropertyChanged("PlantYield"); } }
        private int _plantyield;
        private int randmult;
        public int totalTimetoHarvest { get; set; }
        Random random = new Random();
        public bool IsPlanted { get { return _isplanted; } set { _isplanted = value; RaisePropertyChanged("IsPlanted"); } }

        public int TimeToFarm { get { return _timetofarm; } set { _timetofarm = value; RaisePropertyChanged("TimeToFarm"); } }
        public int Price { get { return _price; } set { _price = value; RaisePropertyChanged("Price"); } }
        public Plant(string PlantName,int Price,int TimeToFarm)
        {
            this.PlantName = PlantName;
            this.TimeToFarm = TimeToFarm;

            this.Price = Price;
            totalTimetoHarvest = TimeToFarm;
            _farmingtimer.Tick += _farmingtimer_Tick;
            _farmingtimer.Interval = TimeSpan.FromSeconds(1);
            PlantBackground = new SolidColorBrush(Colors.SaddleBrown);
            _farmingtimer.Stop();
        }
        public void Sow()
        {
            if (!_farmingtimer.IsEnabled)
            {
                WaterLevel = 100;
                _farmingtimer.Start();
                IsPlanted = true;
            }
        }
        private void _farmingtimer_Tick(object? sender, EventArgs e)
        {
            if (WaterLevel <= 0)
            {
                _farmingtimer.Stop(); 
                return;
            }
            TimeToFarm--;
            WaterLevel = WaterLevel - random.Next(1,totalTimetoHarvest / 2);
            if (TimeToFarm <= 0)
            {
                PlantBackground = new SolidColorBrush(Colors.Green);
                IsPlanted = false;
                _farmingtimer.Stop();    
            }
        }

        public Plant(string PlantName, int Price, int TimeToFarm,Image Icon)
        {
            this.PlantName = PlantName;
            this.TimeToFarm = TimeToFarm;
            this.PlantIcon = Icon;
            this.Price = Price;
            totalTimetoHarvest = TimeToFarm;
            _farmingtimer.Tick += _farmingtimer_Tick;
            _farmingtimer.Interval = TimeSpan.FromSeconds(1);
            PlantBackground = new SolidColorBrush(Colors.SaddleBrown);
            WaterLevel = 100;
            _farmingtimer.Start();
            IsPlanted = true;
        }
        public void Harvest()
        {
            randmult = random.Next(1, 5);
            TimeToFarm = totalTimetoHarvest;
            PlantYield = randmult * Price / 2;


        }
        public void Water()
        {
            WaterLevel = 100;
            if(_farmingtimer.IsEnabled)
            {
                return;
            }
            else if(IsPlanted)
            {
                _farmingtimer.Start();
            }
            else
            {
                return;
            }
        }

    }
}
