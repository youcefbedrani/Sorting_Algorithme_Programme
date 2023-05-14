using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingProgramme
{
    internal class BubbleSortEngine : IsortEngine
    {
        //private bool _sorted = false;
        private int[] Array;
        private Graphics g;
        private int MaxVal;
        Brush WhiteBrudh = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlsckBrudh = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        public BubbleSortEngine(int[] Array_In, Graphics g_In, int MaxVal_In)
        {
            Array = Array_In;
            g = g_In;
            MaxVal = MaxVal_In;
        }
        public void NextStep()
        {
            for (int i = 0; i < Array.Count() - 1; i++)
            {
                if (Array[i] > Array[i + 1])
                {
                    Swap(i, i + 1);
                }
            }
        }
        private void Swap(int i, int v)
        {
            int temp  = Array[i];
            Array[i] = Array[v];
            Array[v] = temp;
            DrawLine(i, Array[i]);
            DrawLine(v, Array[v]);
        }
        private void DrawLine(int i, int v)
        {
            g.FillRectangle(BlsckBrudh, i, 0, 1, MaxVal);
            g.FillRectangle(WhiteBrudh, i, MaxVal - Array[i], 1, MaxVal);
        }
        public bool IsSorted()
        {
            for (int i=0; i<Array.Count() - 1 ; i++)
            {
                if (Array[i] > Array[i+1])
                {
                    return false;
                }
            }
            return true;
        }
        public void reDraw()
        {
            for (int i = 0; i < (Array.Count() - 1); i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, MaxVal - Array[i], 1, MaxVal);
            }
        }
    }
}
