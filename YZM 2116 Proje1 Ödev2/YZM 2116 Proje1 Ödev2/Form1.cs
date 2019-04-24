using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace YZM_2116_Proje1_Ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int size = 15;
        SimpleQueue sq = new SimpleQueue(45);
        Stack st = new Stack(15);
        CircleLinkedList cl = new CircleLinkedList(15);
        

        public void SimpleQueue()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < size; i++)
            {
                Arac uye = sq.Queue[i];
                if (uye != null)
                {
                    string[] uyeStr = { uye.Numara.ToString(), uye.Renk.ToString() };
                    dataGridView1.Rows.Add(uyeStr);

                }
                else
                    continue;
            }

        }

        public void CircleLinkedList()
        {
            dataGridView2.Rows.Clear();
            List<Arac> list = cl.Liste();

            for (int i = 0; i < size; i++)
            {
                Arac uye = list[i];
                if (uye != null)
                {
                    string[] uyeStr = { uye.Numara.ToString(), uye.Renk.ToString() };
                    dataGridView2.Rows.Add(uyeStr);

                }
                else
                    continue;
            }

        }

        public void Stack()
        {
            dataGridView3.Rows.Clear();
            for (int i = 0; i < size; i++)
            {
                Arac uye = st.items[i];
                if (uye != null)
                {
                    string[] uyeStr = { uye.Numara.ToString(), uye.Renk.ToString() };
                    dataGridView3.Rows.Add(uyeStr);

                }
                else
                    continue;
            }

        }

        Random r = new Random();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= size*3; i++)
            {
                Thread.Sleep(10);
                Arac a = new Arac();
                a.Numara = i;
                a.Renk = a.Renkler[r.Next(0, 5)];

                if (i < (size+1))
                {
                    st.Push(a);

                }
                    
                else if (i < (size*2+1) && i >= (size+1))
                {
                    sq.Insert(a);
                  
                }
                    
                else
                {
                    cl.InsertLast(a);
                    
                }
                    
            }
            Stack();
            SimpleQueue();
            CircleLinkedList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Araç Numarası";
            dataGridView1.Columns[1].Name = "Renk";

            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].Name = "Araç Numarası";
            dataGridView2.Columns[1].Name = "Renk";            

            dataGridView3.ColumnCount = 2;
            dataGridView3.Columns[0].Name = "Araç Numarası";
            dataGridView3.Columns[1].Name = "Renk";
        }

        Arac tasima;
        Node _tasima;

        private void btnCikart_Click(object sender, EventArgs e)
        {            

            int sans = r.Next(1, 3);
            

            if (cl.Size == 0 && st.Top == -1)
            {
                tasima = sq.Remove();  
                MessageBox.Show(tasima.Numara + " Numaralı ve " + tasima.Renk + " Renkli araç çıktı.");
                //SimpleQueue();
            }
            
            else
            {
                switch (sans)
                {
                    case 1:
                        _tasima = cl.DeletePos();
                        sq.Insert(_tasima.Data);
                        
                        //if (_tasima.Data == null)
                        //    size--;
                        MessageBox.Show(_tasima.Data.Numara + " Numaralı ve " + _tasima.Data.Renk + " Renkli araç çıktı.");
                       // CircleLinkedList();

                        break;
                    case 2:
                        tasima = st.Pop();
                        sq.Insert(tasima);                        
                        MessageBox.Show(tasima.Numara + " Numaralı ve " + tasima.Renk + " Renkli araç çıktı.");
                        //Stack();

                        break;
                }
            }

            size--;
            Stack();
            SimpleQueue();
            CircleLinkedList();
        }
    }
}
