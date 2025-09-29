using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES01persone
{
    public class clsPersona
    {
        private string cognome;
        private string nome;
        private string dataNascita;

        public string Cognome
        {
            get
            {
                return cognome;
            }
            set
            {
                if (!controllaStringa(value))
                    throw new Exception("COGNOME NON VALIDO");
                else
                    cognome = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (!controllaStringa(value))
                    throw new Exception("NOME NON VALIDO");
                else
                    nome = value;
            }
        }
        public string DataNascita
        {
            get
            {
                return dataNascita;
            }
            set
            {
                DateTime tempDate;
                if (DateTime.TryParse(value, out tempDate))
                {
                    if (tempDate > DateTime.Now)
                        throw new Exception("si accettano date fino ad oggi");
                    dataNascita = value;
                }
                else
                {
                    throw new Exception("data non valida");
                }
            }
        }

        private bool controllaStringa(string nominativo)
        {
            bool ok = true;
            foreach (Char c in nominativo)
            {
                if (!Char.IsLetter(c) && c != ' ' && c != '\'')
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        public virtual string visualizza()
        {
            return $"{cognome} {nome} nata/o il {dataNascita}";
        }

        public int calcolaEtà()
        {
            DateTime dataNascitaDateTime = Convert.ToDateTime(dataNascita);
            int anni = DateTime.Now.Year - dataNascitaDateTime.Year - 1;

            if (DateTime.Now.Month > dataNascitaDateTime.Month ||
                (DateTime.Now.Month == dataNascitaDateTime.Month && DateTime.Now.Day >= dataNascitaDateTime.Day))
            {
                anni++;
            }

            return anni;
        }

        public bool maggiorenne()
        {
            return calcolaEtà() >= 18;
        }

        public clsPersona() { }

        public clsPersona(string _cognome, string _nome, string _dataDiNascita)
        {
            Cognome = _cognome;
            Nome = _nome;
            DataNascita = _dataDiNascita;
        }
    }
}
