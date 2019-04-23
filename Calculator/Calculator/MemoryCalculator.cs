using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class MemoryCalculator : Calculator
    {
        private decimal memoryValue;

        public void MemoryStore()
        {
            memoryValue = CurrentValue;
        }

        public void MemoryRecall()
        {
            CurrentValue = memoryValue;
        }

        public void MemoryAdd(decimal displayValue)
        {
            memoryValue += displayValue;
        }

        public void MemoryClear()
        {
            memoryValue = 0;
        }

        public decimal MemoryValue
        {
            get { return memoryValue; }
        }
    }
}
