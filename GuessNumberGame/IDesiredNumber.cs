using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    internal interface IDesiredNumber
    {
        public CompareTypes CompareNumber(int number);
        public int Number {  get; set; }
    }
}
