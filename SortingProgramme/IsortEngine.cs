using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProgramme
{
    internal interface IsortEngine
    {
        //void Dowork(int[] Array , Graphics g , int MaxVal);
        void NextStep();
        bool IsSorted();
        void reDraw();
    }
}
