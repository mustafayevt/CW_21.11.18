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
            MyList  <int>list = new MyList<int>();
            list.Add(5);
            list.Add(6);
            list.Show();
            Console.WriteLine(list.Contains(5));
        }
    }
    class MyList<T>
    {
        public T []GetT=new T[0];
        public void Add(T tmp)
        {
            Array.Resize(ref GetT, GetT.Length + 1);
            GetT[GetT.Length - 1] = tmp;
        }
        public bool Contains(T tmp)
        {
            for (int i = 0; i < GetT.Length; i++)
            {
                if (GetT[i].Equals(tmp)) return true;
            }
            return false;
        }
        public  void Show()
        {
            for (int i = 0; i < GetT.Length; i++)
            {
                Console.WriteLine(GetT[i]);
            }
        }
    }
}
