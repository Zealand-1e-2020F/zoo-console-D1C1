using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Tun : DyreTyper.Fisk
    {
        public Tun(string navn, string foder) : base(navn, foder)
        {
        }

        public override bool IsByttedyr()
        {
            throw new NotImplementedException();
        }

        public override bool IsRovdyr()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + "tun";
        }
    }
}
