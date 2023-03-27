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

        public void PrenotaPosti(int x)
        {
            if (x > 0)
            {
                if (data > DateTime.Now)
                {
                    postiPrenotati += x;
                    if (postiPrenotati > capienza)
                    {
                        postiPrenotati -= x;
                        throw new Exception("I posti prenotati non possono superare la capienza massima");
                    }
                } else throw new Exception("Non si possono prenotare posti per un evento già concluso");
            }
            else throw new Exception("I posti prenotati non possono essere un numero negativo o uguale a 0");
        }

        public void DisdiciPosti(int x)
        {
            if (x > 0)
            {
                if (data > DateTime.Now)
                {
                    postiPrenotati -= x;
                    if (postiPrenotati < 0)
                    {
                        postiPrenotati += x;
                        throw new Exception("I posti non possono essere meno di 0");
                    }
                }
                else throw new Exception("Non si possono disdire posti per un evento già concluso");
            }
            else throw new Exception("I posti disdetti non possono essere un numero negativo o uguale a 0");
        }

        public override string ToString() => $"{data.ToString("dd/MM/yyyy")} - {titolo}";
    }
}
