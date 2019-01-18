﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_TriangleSort.Model
{
    public interface IFigure : IComparable<IFigure>
    {
        string Name { get; set; }

        double GetArea();
    }
}
