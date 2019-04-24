using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev2
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertLast(Arac value);
        public abstract Node DeletePos();
        public abstract Node GetElement(int position);
        public abstract string DisplayElements();

    }
}
