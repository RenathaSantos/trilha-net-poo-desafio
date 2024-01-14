using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"12345678", modelo:"1100",imei:"123",memoria:5);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"87654321", modelo:"12",imei:"321",memoria:8);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
