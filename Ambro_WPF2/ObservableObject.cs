/**
 * With Help from: ToskersCorner @ https://www.youtube.com/watch?v=olBEvYKWNYI
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ambro_WPF2
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // passing as ref to change directly with value
        // abastracts from changing properties in models
        public void OnPropertyChanged<T>(ref T property, T value, [CallerMemberName] string propertyName = "")
        {
            /*
             * Whatever member is calling this method,
             * CallerMemberName auto grabs the name of the caller
             */
            property = value;
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
