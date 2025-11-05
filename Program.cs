using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "123456", modelo: "Modelo C1", imei: "11111111", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone Iphone = new Iphone(numero: "654321", modelo: "Modelo 12", imei: "2222222", memoria: 128);
Iphone.Ligar();
Iphone.InstalarAplicativo("Telegram");


