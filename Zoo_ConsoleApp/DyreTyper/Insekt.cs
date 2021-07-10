using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp.DyreTyper
{
    abstract class Insekt : Dyr, IRovdyr, IByttedyr
    {
        public Insekt(string navn, string foder) : base(navn, foder)
        {
        }

        public abstract bool IsByttedyr();

        public abstract bool IsRovdyr();
    }
}
