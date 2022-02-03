using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorterApp
{
    public class Logic
    {
        private string _text;
        private string _rule;
        private string _result;

        //Входной массив
        public string Text
        {
            get { return _text; }
            set
            {
                if (value.Length > 0 & value.Length < 16)
                {
                    _text = value.ToUpper();
                }
                if (value.Length > 15)
                {
                    throw new ArgumentException("Длина поля 'Входной массив' не более 15 символов");
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException("Поле 'Входной массив' не может быть пустым");
                }
            }
        }

        //Правило сортировки по цветам
        public string Rule
        {
            get { return _rule; }
            set { _rule = value; }
        }

        //Отсортированный массив
        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }

        //Метод сортировки входного массива по правилу сортировки
        public void Sorting()
        {
            foreach (var x in _rule)
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
