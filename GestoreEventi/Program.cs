using GestoreEventi;

var test = new Evento("eventoprova", new DateTime(2023, 03, 28), 50);
Console.WriteLine(test.Titolo);
Console.WriteLine(test.Data);
Console.WriteLine(test.Capienza);
Console.WriteLine(test.PostiPrenotati);