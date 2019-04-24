using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev2
{
    public interface IQueue
    {
        void Insert(Arac o);
        Arac Remove();
        Arac Peek();
        bool IsEmpty();
    }
}
