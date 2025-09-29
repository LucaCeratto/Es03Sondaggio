using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ES01persone;

namespace Es03Sondaggio
{
    internal class clsElencoSondaggio : clsElenco
    {
        public int contaDipendentiPartTime()
        {
            int conta = 0;

            foreach(clsPersona x in lista)
            {
                if(x is clsDipendenti)
                {
                    if((x as clsDipendenti).PartTime == "True")
                    {
                        conta++;
                    }
                }
            }

            return conta;
        }

        public int contaDipendenti()
        {
            int conta = 0;

            foreach (clsPersona x in lista)
            {
                if (x is clsDipendenti)
                {
                        conta++;
                }
            }

            return conta;
        }
    }
}
