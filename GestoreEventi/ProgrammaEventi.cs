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

        //public void MostraEventi()
        //{
        //    foreach (Evento evento in eventi)
        //    {
        //        Console.WriteLine(evento.Titolo);
        //    }
        //}

        public void MostraProgramma()
        {
            Console.WriteLine(Titolo);
            foreach (Evento evento in eventi)
            {
                Console.WriteLine(evento.ToString());
            }
        }

        public static void StampaEventi(List<Evento> lista)
        {
            foreach (Evento evento in lista)
            {
                Console.WriteLine(evento.Titolo);
            }
        }

        public int NumeroEventi() 
        {
            return eventi.Count;
        }

        public void SvuotaListaEventi()
        {
            eventi.Clear();
        }
    }
}
