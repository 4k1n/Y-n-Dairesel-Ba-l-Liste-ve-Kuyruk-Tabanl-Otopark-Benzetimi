using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev2
{
    public class SimpleQueue : IQueue
    {
        public Arac[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        public int count = 0;

        public SimpleQueue(int size)
        {
            this.size = size;
            Queue = new Arac[size];
        }
        public void Insert(Arac o)
        {
            if (count == size)
            {
                throw new Exception("Katta boş yer bulunmamaktadır.");
            }
            if (front == -1)
                front = 0;
            rear++;
            if (rear == 15)
            { rear = 0; }
            Queue[rear] = o;
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public Arac Peek()
        {
            return Queue[front];
        }

        public Arac Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Katta araç bulunmamaktadır.");
            }
            Arac temp = Queue[front];
            Queue[front] = null;
            front++;
            if (front == 15)
                front = 0;
            count--;
            return temp;
        }
    }
}
