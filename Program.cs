using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia: ");
Nokia N1 = new Nokia(numero: "956784578", modelo: "Modelo 01", imei: "11111111", memoria: 128);
N1.Ligar();
N1.InstalarAplicativo("WhatsApp");

Console.WriteLine("-------------------------");


Console.WriteLine("SmartPhone Iphone: ");
Iphone i1 = new Iphone(numero: "945384596", modelo: "Modelo 02", imei: "0000000", memoria: 128);
i1 .Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");

