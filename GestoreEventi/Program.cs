using GestoreEventi;

//var test = new Evento("eventoprova", new DateTime(2023, 03, 29), 70);


Console.WriteLine("Inserisci il nome dell'evento");
var titolo = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyyy)");
var datastring = Console.ReadLine();

DateTime data = Convert.ToDateTime(datastring);

Console.WriteLine("Inserisci il numero di posti totali");
var capienza = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quanti posti desideri prenotare?");
var postiPrenotati = Convert.ToInt32(Console.ReadLine());

var evento = new Evento(titolo, data, capienza);
evento.PrenotaPosti(postiPrenotati);

bool loop = true;
Console.WriteLine($"Posti prenotati: {evento.PostiPrenotati}");
Console.WriteLine($"Numero di posti rimanenti: {evento.Capienza - evento.PostiPrenotati}");

while (loop)
{
    Console.WriteLine("Vuoi disdire dei posti? (si/no)");
    var input = Console.ReadLine();
    switch (input)
    {
        case "si":
            Console.WriteLine("Indica il numero di posti da disdire");
            var postiDisdetti = Convert.ToInt32(Console.ReadLine());
            evento.DisdiciPosti(postiDisdetti);
            postiPrenotati = evento.PostiPrenotati;
            Console.WriteLine($"Posti prenotati: {evento.PostiPrenotati}");
            Console.WriteLine($"Numero di posti rimanenti: {evento.Capienza - evento.PostiPrenotati}");
            break;
        case "no":
            Console.WriteLine("Ok");
            loop = false;
            break;
        default:
            Console.WriteLine("Comando non riconosciuto");
            break;
    }
}

Console.WriteLine($"\nDettagli evento: \n{evento.ToString()}");
Console.WriteLine($"Capienza massima: {evento.Capienza}");
Console.WriteLine($"Posti prenotati: {evento.PostiPrenotati}");
Console.WriteLine($"Posti rimanenti: {evento.Capienza - postiPrenotati}");
