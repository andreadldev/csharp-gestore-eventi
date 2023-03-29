using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        public string Titolo;
        public List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> EventiInData(DateTime data)
        {
            var res = new List<Evento>();
            foreach (Evento evento in eventi)
            {
                if(evento.Data == data)
                {
                    res.Add(evento);
                }
            }

            return res;
        }


        public static string StampaEventi(List<Evento> lista)
        {
            var line = Environment.NewLine;
            string res = string.Empty;

            foreach (var evento in lista)
            {
                res += evento.ToString() + line;
            }

            return res;
        }

        public int NumeroEventi() 
        {
            return eventi.Count;
        }

        public void SvuotaListaEventi()
        {
            eventi.Clear();
        }

        public void MostraProgramma()
        {
            Console.WriteLine(Titolo);
            foreach (Evento evento in eventi)
            {
                Console.WriteLine(evento.ToString());
            }
        }
    }
}
