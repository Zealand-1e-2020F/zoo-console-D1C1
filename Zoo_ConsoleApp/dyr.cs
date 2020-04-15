using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    /// <summary>
    /// base klasse for dyr i zoo
    /// </summary>
    public class Dyr : IRovdyr,IByttedyr
    {
        private string _foder;
        public string DyreNavn { get; }
        public string Foder { get => _foder; set => _foder = value; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Dyr()
        {

        }

        /// <summary>
        /// cosntructor som tager dyrenavn som parameter
        /// </summary>
        /// <param name="navn">navnet på typen af dyr</param>
        public Dyr(string navn, string foder)
        {
            this.DyreNavn = navn;
            this.Foder = foder;

        }

        public virtual bool IsByttedyr()
        {
            return false;
        }

        public virtual bool IsRovdyr()
        {
            return false;
        }
    }
}
