﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_TriangleSort.Model;

namespace Task3_TriangleSort.UI
{
    interface IView
    {
        void PrintInstructionText(string text);
        void PrintErrorText(string text);
        void PrintResult(TriangleSorter triangleSorter);
        void AskInputTriangle(string text);
        void AskContinueFlag(string text);
        void AskAddTrianglesFlag(string text);

        string GetTriangle();
        string GetContinueFlag();
        string GetAddTrianglesFlag();

        event EventHandler SetTriangle;
        event EventHandler AddTriangle;
        event EventHandler EndWork;
    }
}
