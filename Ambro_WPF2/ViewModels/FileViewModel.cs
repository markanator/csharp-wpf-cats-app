using System;
using System.Collections.Generic;
using System.Text;
using Ambro_WPF2.Models;
using System.Windows.Input;
using Microsoft.Win32;
using System.IO;
using System.Windows;


namespace Ambro_WPF2.ViewModels
{
    public class FileViewModel
    {
        public Cat TheCat { get; private set; }
        // TOOLBAR COMMANDS
        public ICommand OpenCommand { get; }
        public ICommand SaveCommand { get; }

        public FileViewModel(Cat c)
        {
            TheCat = c;
            OpenCommand = new RelayCommand(OpenFile);
            SaveCommand = new RelayCommand(SaveFile);
        }

        private void OpenFile() {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Xml File (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                var LoadedCat = XmlFileIO.OpenFile<Cat>(openFileDialog.FileName);
                if (LoadedCat != null)
                {
                    TheCat.Name = LoadedCat.Name;
                    TheCat.Age = LoadedCat.Age;
                    TheCat.Weight = LoadedCat.Weight;
                }
            }
        }
        private void SaveFile() {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Xml File (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == true)
            {
                XmlFileIO.SaveData(TheCat, saveFileDialog.FileName);
            }
        }
    }
}
