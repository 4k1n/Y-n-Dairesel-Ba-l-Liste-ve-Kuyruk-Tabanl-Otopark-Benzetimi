using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev2
{
    public class CircleLinkedList : LinkedListADT
    {



        public CircleLinkedList(int size)
        {
            this.Size = size;
        }

        public override Node DeletePos()
        {
            Node temp = Head;
            Node tempEski = Head;
            int s = Size;
            int sayac = 1;
            while (s != 1)
            {
                if (s % 2 == 0)
                {
                    s /= 2;
                    sayac *= 2;
                }
                else
                    s--;
            }
            if ((2 * (Size - sayac) + 1) != 1)
            {
                for (int i = 1; i < (2 * (Size - sayac) + 1); i++)
                {
                    tempEski = temp;
                    temp = temp.Next;
                }
                tempEski.Next = temp.Next;
                Size--;
            }
            else
            {
                if (Size != 1)
                {
                    while (tempEski.Next != Head)
                    {
                        tempEski = tempEski.Next;
                    }
                    tempEski.Next = temp.Next;
                    Head = temp.Next;
                    Size--;
                }
                else
                {
                    Size--;
                }
            }
            return temp;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }

            return temp;
        }

        public override Node GetElement(int position)
        {
            Node retNode = null;
            Node tempNode = Head;
            int count = 0;
            while (tempNode != null)
            {
                if (count == position)
                {
                    retNode = tempNode;
                    break;
                }
                else if (tempNode.Next != Head)
                    tempNode = tempNode.Next;
                count++;
            }
            return retNode;
        }

        public override void InsertLast(Arac value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };
            Node eskiSon = Head;
            if (Head == null)
            {
                Head = tmpHead;
                Head.Next = Head;
            }
            else
            {
                while (eskiSon != null)
                {
                    if (eskiSon.Next != Head)
                    {
                        eskiSon = eskiSon.Next;
                    }
                    else
                        break;
                }
                eskiSon.Next = tmpHead;
                tmpHead.Next = Head;
            }
            Size++;
        }

        public List<Arac> Liste()
        {
            List<Arac> arac = new List<Arac>();

            Node temp = Head;
            while (temp.Next != Head)
            {
                arac.Add(temp.Data);
                temp = temp.Next;
                if (temp.Next == Head)
                    arac.Add(temp.Data);
            }
            return arac;
        }

    }
}
