﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_TriangleSort.Model;

namespace Task3_TriangleSort.UI
{
    class ConsoleView : IView
    {
        private const string BLOCK_SEPARATOR = "==================================================================";
        private const string TRIANGLE_LIST_HEADER = "============= Triangles list: ===============";
        private const string TRIANGLE_LIST_ROW = "{0}. [Triangle {1}]: {2} сm";

        public event EventHandler SetTriangle;
        public event EventHandler AddTriangle;
        public event EventHandler EndWork;

        public void PrintInstructionText(string text)
        {
            Console.WriteLine(BLOCK_SEPARATOR);
            Console.WriteLine(text);
            Console.WriteLine(BLOCK_SEPARATOR);
            Console.WriteLine();
        }

        public void PrintErrorText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(text);
            Console.ResetColor();
            Console.WriteLine();
        }

        public void PrintResult(TriangleSorter triangleSorter)
        {
            Console.WriteLine(TRIANGLE_LIST_HEADER);
            for (int i = 0; i < triangleSorter.Triangles.Count; i++)
            {
                Console.WriteLine(TRIANGLE_LIST_ROW, i + 1, triangleSorter.Triangles[i].Name, triangleSorter.Triangles[i].Area);
                if (i < triangleSorter.Triangles.Count - 1)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public void AskInputTriangle(string text)
        {
            Console.WriteLine(text);
            SetTriangle?.Invoke(this, new EventArgs());
        }

        public string GetTriangle()
        {
            return Console.ReadLine();
        }

        public void AskAddTrianglesFlag(string text)
        {
            Console.WriteLine(text);
            AddTriangle?.Invoke(this, new EventArgs());
        }

        public string GetAddTrianglesFlag()
        {
            return Console.ReadLine();
        }

        public void AskContinueFlag(string text)
        {
            Console.WriteLine(text);
            EndWork?.Invoke(this, new EventArgs());
        }

        public string GetContinueFlag()
        {
            return Console.ReadLine();
        }
    }
}
