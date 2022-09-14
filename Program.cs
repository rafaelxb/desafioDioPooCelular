using DesafioPOO.Models;

Console.WriteLine("New Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "123123123", modelo: "Modelo Nokia 1", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.DetalhesSmartphone();

Console.WriteLine("\n");
Console.WriteLine("---------------------");
Console.WriteLine("\n");

Console.WriteLine("New Smartphone Iphone");
Smartphone iphone = new Iphone (numero: "456456456", modelo: "Modelo Iphone 1", imei: "789456123", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.DetalhesSmartphone();