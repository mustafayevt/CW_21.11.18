using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_21._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, int> keyValuePairs = new MyList<int, int>();
            keyValuePairs[1] = 5;
            Console.WriteLine(keyValuePairs[1]);
        }
    }
    class MyList<T, R>
    {
        T[] key = new T[0];
        R[] value = new R[0];
        public void Add(T key, R value)
        {
            for (int i = 0; i < this.key.Length; i++)
            {
                if (this.key[i].Equals(key)) throw new Exception("Key is already taken");
            }
            Array.Resize(ref this.key, this.key.Length + 1);
            this.key[this.key.Length - 1] = key;
            Array.Resize(ref this.value, this.value.Length + 1);
            this.value[this.value.Length - 1] = value;
        }


        public object this[T index]
        {
            get
            {
                for (int i = 0; i < this.key.Length; i++)
                {
                    if (this.key[i].Equals(index)) return value[i];
                }
                throw new Exception("Not found");
            }
            set
            {
                if (!key.Contains(index))
                {
                    Array.Resize(ref this.value, this.value.Length + 1);
                    this.value[this.value.Length - 1] = (R)value;
                    Array.Resize(ref this.key, this.key.Length + 1);
                    this.key[this.key.Length - 1] = index;
                }
                else
                {
                    this.value[Array.IndexOf(key, index)] = (R)value;
                }
            }
        }
    }

}
