using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    internal class Logic
    {
        private string _text;
        private string _sort;
        private string _result = String.Empty;

        public string Text
        {
            get { return _text; }
            set
            {
                if (value.Length > 0 & value.Length < 16)
                {
                    _text = value;
                }
                else if(value.Length > 16)
                {
                    throw new ArgumentException("Максимум 15 символов");
                }
                if(value.Length == 0)
                {
                    throw new ArgumentException("Поле не может быть пустым");
                }
            }
        }

        public string Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }

        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public void Sorting()
        {
            string result = string.Empty;
            foreach (var x in _sort)
            {
                foreach (char y in _text)
                {
                    if (y == x)
                    {
                        _result = _result + y;
                    }
                }
            }
        }
    }
}
