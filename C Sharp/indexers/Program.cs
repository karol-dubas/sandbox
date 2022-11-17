using System;

namespace indexers
{
    class Program
    {
        static void Main()
        {
            Words words = new();
            words[1] = "word 11";
            string x = words[9];
            //var x = words[10];
        }
    }

    class Words
    {
        private const int _length = 10;
        private string[] _words = new string[_length];

        public Words()
        {
            for (int i = 0; i < _length; i++)
                _words[i] = $"word {i}";
        }

        public string this[int index]
        {
            get => _words[index];
            set => _words[index] = value;
        }
    }
}
