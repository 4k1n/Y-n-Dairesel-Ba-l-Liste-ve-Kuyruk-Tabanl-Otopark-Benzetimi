using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev2
{
    public interface IStack
    {
        void Push(Arac item);
        Arac Pop();
        Arac Peek();
        bool IsEmpty();
        int Top { get; set; }
    }

}
