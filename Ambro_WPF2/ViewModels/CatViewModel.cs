using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Ambro_WPF2.Models;

namespace Ambro_WPF2.ViewModels
{
    class CatViewModel : BaseViewModel
    {
        private Cat cat;

        public CatViewModel(Cat c)
        {
            this.cat = c;
        }

        // wrapped variables from class exposed to UI
        public int Age { get => cat.Age; }
        public string AboutString { get => cat.About(); }

        public int Weight
        {
            get => cat.Weight;
            set
            {
                cat.Weight = value;
                OnPropertyChanged();
                OnPropertyChanged("AboutString");
            }
        }

        public string Name
        {
            get => cat.Name;
            set
            {
                cat.Name = value;
                OnPropertyChanged();
                OnPropertyChanged("AboutString");
            }
        }



    }
}
