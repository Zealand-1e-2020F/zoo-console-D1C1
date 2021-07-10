using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp.DyreTyper
{
    abstract class Fisk : Dyr, IRovdyr, IByttedyr
    {
        public Fisk(string navn, string foder) : base(navn, foder)
        {
        }

        public abstract bool IsByttedyr();
        public abstract bool IsRovdyr();
 
    }
}
