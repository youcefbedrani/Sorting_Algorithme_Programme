using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProgramme
{
    internal class InsertionSort : IsortEngine
    {
        //private bool _sorted = false;
        private int[] Array;
        private Graphics g;
        private int MaxVal;
        Brush WhiteBrudh = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlsckBrudh = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        public InsertionSort(int[] Array_In, Graphics g_In, int MaxVal_In)
        {
            Array = Array_In;
            g = g_In;
            MaxVal = MaxVal_In;
        }
        public void NextStep()
        {
            for (int i = 1; i < Array.Count(); ++i)
            {
                int key = Array[i];
                int j = i - 1;
                while (j >= 0 && Array[j] > key)
                {
                    Array[j + 1] = Array[j];
                    DrawLine(j + 1, Array[j + 1]);
                    j = j - 1;
                }
                Array[j + 1] = key;
                DrawLine(j + 1, Array[j + 1]);
            }
        }
        private void Swap(int i, int j)
        {
            int temp = Array[i];
            Array[i] = Array[j];
            Array[j] = temp;
            DrawLine(i, Array[i]); 
            DrawLine(j, Array[j]); 
        }
        private void DrawLine(int i, int v)
        {
            g.FillRectangle(BlsckBrudh, i, 0, 1, MaxVal);
            g.FillRectangle(WhiteBrudh, i, MaxVal - Array[i], 1, MaxVal);
        }
        public bool IsSorted()
        {
            for (int i = 0; i < Array.Count() - 1; i++)
            {
                if (Array[i] > Array[i + 1])
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
