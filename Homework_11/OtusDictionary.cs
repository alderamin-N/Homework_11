using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    public class OtusDictionary
    {
        private string?[] _array = new string[32];
        public string? this[int i]
        {
            get { return Get(i); }
            set { Add(i, value); }
        }
        public void Add(int key, string? value)
        {
           if (value == null)
            {
                throw new InvalidOperationException("Словарь не может сохранять null");
            }
           while(key > _array.Length)
            {
                string[] newArray = new string[_array.Length * 2];
                _array.CopyTo(newArray, 0);
                _array = newArray;
            }            
            if (_array[key] != null)
            {
                throw new InvalidOperationException("Место уже занято!");
            }
            _array[key] = value;
        }

        public string? Get(int key)
        { 
            if (key < _array.Length)
            {
                return _array[key];
            }
            return null;
        }
    }
}
