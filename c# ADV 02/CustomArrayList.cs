using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__ADV_02
{
    internal class CustomArrayList
    {
        private ArrayList list;


        public CustomArrayList()
        {
            list = new ArrayList();
        }


        public void Add(int element)
        {
            list.Add(element);
        }


        public void Print()
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return base.ToString();
        }


        public void Reverse()
        {



            int left = 0;
            int right = list.ToArray().Length - 1;

            while (left < right)
            {
                Object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
    }
}
