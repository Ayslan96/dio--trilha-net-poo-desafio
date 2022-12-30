using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("9999-9999","1100","123456",128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone("7777-8989","11","987654",4096);
iphone.Ligar();
iphone.InstalarAplicativo("Google Hangouts");
iphone.ReceberLigacao();

