using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;
        private int _health;
        public string CurrentColor => _health >= 5 ? Color.HealthyColor : Color.SickColor;
        public CatColor Color { get; set; }

        public Cat(string age, CatColor color)
        {
            _health = 5;
            Age = age;
            Color = color;
        }

        public string Age { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {

                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }

        public void Punish()
        {
            _health--;
        }

        public void Feed()
        {
            _health++;
        }
    }
}
