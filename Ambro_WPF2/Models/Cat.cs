using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambro_WPF2.Models
{
    [Serializable]
    public class Cat : ObservableObject
    {
        private int _age;
        public int Age {
            get => _age;
            set { OnPropertyChanged(ref _age, value); }
        }
        // private instance member
        private int _weight;
        public int Weight
        {
            get => _weight;
            set { OnPropertyChanged(ref _weight, value); }
        }
        private string _name;
        public string Name
        {
            get => _name;
            set { OnPropertyChanged(ref _name, value); }
        }

        public void HappyBirthday()
        {
            this.Age++;
        }

        public string About()
        {
            return $"Hello my name is {this.Name}. I am {this.Age} yrs old and weigh {this.Weight} pounds, meow!";
        }

        public Cat()
        {
            this.Age = 5;
            this.Weight = 7;
            this.Name = "Whiskerrrs";
        }
        /*protected Cat(SerializationInfo info, StreamingContext context)
        {
            Age = info.GetInt32("Age");
            Weight = info.GetInt32("Weight");
            Name = info.GetString("Name");
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Age", Age);
            info.AddValue("Weight", Weight);

        }*/
    }
}