using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp.DyreTyper
{
    abstract class Pattedyr : Dyr, IRovdyr, IByttedyr
    {
        public Pattedyr(string navn, string foder) : base(navn, foder)
        {
        }

        public abstract bool IsByttedyr();

        public abstract bool IsRovdyr();
    }
}
