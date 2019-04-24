using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev2
{
    public class Stack : IStack
    {
        public Arac[] items;
        private int top = -1;

        public Stack(int itemCount)
        {
            this.items = new Arac[itemCount];
        }
        public void Push(Arac item)
        {
            if (items.Length == Top + 1)
            {
                throw new Exception("Kat dolu");
            }
            items[++Top] = item;
        }

        public Arac Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Kat boş");
            }
            Arac temp = items[Top--];
            return temp;
        }

        public Arac Peek()
        {
            return items[Top];
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
    }
}
