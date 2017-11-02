﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoreNET
{
    public interface ISerialize
    {
        void Save(List<Storage> list);

        List<Storage> Load();
    }
}
