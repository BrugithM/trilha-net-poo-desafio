using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero:"123456789", modelo:"Nokia", imei:"123456789", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone:");
Iphone iphone = new Iphone(numero:"987654321", modelo:"Iphone", imei:"987654321", memoria:256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");