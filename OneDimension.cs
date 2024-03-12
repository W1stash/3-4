using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class OneDimension : IArray
    {
        Random rnd = new Random();
        private dynamic[] array;
        private int length;
        public OneDimension(int a)
        {
            length = a;
            array = new dynamic[length];
        }
        public dynamic this[int i]
        {
            set
            {
                array[i] = value;
            }
            get
            {
                return array[i];
            }
        }
        public dynamic[] Array()
        {
            return array;
        }

        void IArray.Init()
        {
            for(int i = 0; i < length; i++)
            {
                array[i] = "bob";
            }
        }

        void IPrinter.Print()
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
