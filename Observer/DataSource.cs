using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    
    public class DataSource : Subject
    {
        private int _value;
        public int Value{
            get => _value;
            set 
            {
                _value = value;
                NotifyObservers();
            }
        }
    }
}
