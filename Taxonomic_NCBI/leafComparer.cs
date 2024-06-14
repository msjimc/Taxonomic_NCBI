﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomic_NCBI
{
    class leafComparer : IComparer<leaf>
    {
        int IComparer<leaf>.Compare(leaf x, leaf y)
        {
            return x.getNameLowerCase.CompareTo(y.getNameLowerCase);
        }
    }
}
