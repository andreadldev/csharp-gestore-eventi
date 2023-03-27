using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienza;
        private int postiPrenotati;

        public string Titolo
        {
            get => titolo;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    titolo = value;
                }
                else throw new Exception("Il titolo non può essere una stringa vuota");
            }
        }

        public DateTime Data
        {
            get => data;
            set
            {
                if (value > DateTime.Now)
                {
                    data = value;
                }
                else throw new Exception("La data non può essere una data passata");
            }
        }

        public int Capienza {
            get => capienza;
            private set
            {
                if (value > 0)
                {
                    capienza = value;
                }
                else throw new Exception("La capienza massima non può essere zero o un numero negativo");
            }
        }

        public int PostiPrenotati
        {
            get => postiPrenotati;
            private set { }
        }

        public Evento(string titolo, DateTime data, int capienza)
        {
            Titolo = titolo;
            Data = data;
            Capienza = capienza;
            postiPrenotati = 0;
        }
    }
}
