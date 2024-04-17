using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppcustomlist
{
    
        public class CustomList<T>
        {
            private List<T> Listler;

            public CustomList()
            {
                Listler = new List<T>();
            }

            public void Add(T item)
            {
                Listler.Add(item);
            }

            public bool Remove(T item)
            {
                return Listler.Remove(item);
            }

            public int Count()
            {
                return Listler.Count;
            }

            public T GetItem(int index)
            {
                if (index >= 0 && index < Listler.Count)
                {
                    return Listler[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index sehv daxil edilib");
                }
            }

            public void Print()
            {
                foreach (var item in Listler)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

