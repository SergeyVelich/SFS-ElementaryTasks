﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_TriangleSort.Model
{
    interface ISorter
    {
        List<IFigure> Triangles { get; set; }

        void Sort(IComparer<IFigure> comparer);
    }
}
