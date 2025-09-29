using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES01persone
{
    internal class clsElenco
    {
        protected List<clsPersona> lista;

        public List<clsPersona> Lista
        {
             get { return lista; }
        }

        //costruttore
        public clsElenco()
        {
            //istanzia la lista
            lista = new List<clsPersona>();
        }

        public void aggiungiPersona(clsPersona persona)
        {
            lista.Add(persona);
        }

        public void visualizzaLista(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = lista;
        }

        public string visualizzaPersona(int posizione)
        {
            string s = lista[posizione].visualizza();
            return s;  
        }

        public string ricerca (string cognomeRichiesto)
        {
            string s = "";
            if(lista.Count ==0)
            {
                s = "Lista Vuota";
            }
            else
            {
                foreach(clsPersona persona in lista)
                {
                    if(persona.Cognome.ToUpper()==cognomeRichiesto.ToUpper())
                    {
                        s += persona.visualizza() + "\n";
                    }
                    if(s=="")
                    {
                        s = "Non ci sono persone con quel cognome";
                    }
                }
            }
            return s;
        }

        public string ricercaAnno(int annoRichiesto)
        {
            string s = "";
            if (lista.Count == 0)
            {
                s = "Lista Vuota";
            }
            else
            {
                foreach (clsPersona persona in lista)
                {
                    DateTime Data = Convert.ToDateTime(persona.DataNascita);
                    if (Data.Year == annoRichiesto)
                    {
                        s += persona.visualizza() + "\n";
                    }
                    if (s == "")
                    {
                        s = "Non ci sono persone nate in quell'anno";
                    }
                }
            }
            return s;
        }

        public void cancella (int pos)
        {
            lista.RemoveAt(pos);
        }
    }
}
