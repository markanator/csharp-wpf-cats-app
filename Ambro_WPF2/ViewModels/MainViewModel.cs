using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Ambro_WPF2.Models;
using Ambro_WPF2.Views;

namespace Ambro_WPF2.ViewModels
{
    public class MainViewModel
    {
        private Cat _myCat;
        public Cat MyCat
        {
            get { return _myCat; }
            set { _myCat = value; }
        }
        public FileViewModel File { get; set; }

        public MainViewModel()
        {
            _myCat = new Cat();
            File = new FileViewModel(MyCat);
        }
    }
}
