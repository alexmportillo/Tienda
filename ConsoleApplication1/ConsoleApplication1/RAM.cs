using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public enum RAM
    {
        OneGB, TwoGB, FourGB, EightGB, SixteenGB, ThirtytwoGB
    }

    public class MovilValorSwitch
    {
        public RAM StringToRam(string s)
        {
            switch (s)
            {
                case "1GB":
                    return RAM.OneGB;

                case "2GB":
                    return RAM.TwoGB;
                case "4GB":
                    return RAM.FourGB;
                case "8GB":
                    return RAM.EightGB;
                case "16GB":
                    return RAM.SixteenGB;
                case "32GB":
                    return RAM.ThirtytwoGB;
                default:
                    return 0;
            }
        }
    }

}
