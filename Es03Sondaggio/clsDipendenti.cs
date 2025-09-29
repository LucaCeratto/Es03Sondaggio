using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using ES01persone;

namespace Es03Sondaggio
{
    internal class clsDipendenti : clsPersona
    {
        private string area;
        private bool partTime;

        public string Area { get { return area; } set { area = value; } }

        public string PartTime { get => partTime.ToString(); set => partTime = Convert.ToBoolean(value); }

        public clsDipendenti(string _cognome, string _nome, string _dataNascita, string _area, string _partTime) : base (_cognome,_nome,_dataNascita)
        {
            Area = _area;
            PartTime = _partTime;
        }

        public override string visualizza()
        {
            return $"{base.visualizza()} lavora nell'area {area}, part time: {partTime}";
            //fa riferimento alla classe base dove è stato dichiarato virtual
            //è un polimorfismo, il metodo si comporta in modo diverso a seconda dell'oggetto con cui viene richiamato
        }
    }
}
