using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    abstract class Fisk : Dyr, IRovdyr, IByttedyr
    {
        public abstract bool IsByttedyr();
        public abstract bool IsRovdyr();
 
    }
}
