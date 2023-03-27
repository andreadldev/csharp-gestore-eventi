using GestoreEventi;

var test = new Evento("eventoprova", new DateTime(2023, 03, 29), 70);
Console.WriteLine(test.Titolo);
Console.WriteLine(test.Data);
Console.WriteLine(test.Capienza);
Console.WriteLine(test.PostiPrenotati);

Console.WriteLine(test.ToString());

test.PrenotaPosti(-50);
Console.WriteLine(test.PostiPrenotati);

//test.DisdiciPosti(1);
//Console.WriteLine(test.PostiPrenotati);
