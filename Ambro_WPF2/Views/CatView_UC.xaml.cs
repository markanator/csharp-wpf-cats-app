/**
 * With help from:
 * 1. https://stackoverflow.com/questions/53474161/how-to-pass-data-from-mainwindow-to-a-user-control-thats-inside-the-mainwindow
 * 2. MsDocs
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ambro_WPF2.Models;
using Ambro_WPF2.ViewModels;

namespace Ambro_WPF2.Views
{
    public partial class CatView_UC : UserControl
    {
        public static readonly DependencyProperty CatProperty = DependencyProperty.Register(
            "CatProp", typeof(Cat), typeof(CatView_UC));
        public Cat CatProp
        {
            get { return (Cat)GetValue(CatProperty); }
            set { SetValue(CatProperty, value); }
        }

        public CatView_UC()
        {
            InitializeComponent();
        }
    }
}
