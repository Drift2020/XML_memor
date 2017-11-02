using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoreNET.ISerialize
{
    interface ISerialize
    {
        void Save(List<Storage> list);
    }
}
