using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class TwoDimension : IArray
    {
        Random rnd = new Random();
        private dynamic[,] array;
        private int length;
        private int colum;

        public TwoDimension(int a, int b)
        {
            length = a;
            colum = b;
            array = new dynamic[colum, length];
        }
        public dynamic this[int i, int c]
        {
            set
            {
                array[i, c] = value;
            }
            get
            {
                return array[i, c];
            }
        }
        public dynamic[,] Array()
        {
            return array;
        }

        void IArray.Init()
        {
            for (int i = 0; i < colum; i++)
            {
                for (int c = 0; c < length; c++)
                {
                    array[i, c] = rnd.Next(-100, 100);
                }
            }
        }

        void IPrinter.Print()
        {
            for (int i = 0; i < colum; i++)
            {
                for (int c = 0; c < length; c++)
                {
                    Console.Write($"{array[i, c]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
