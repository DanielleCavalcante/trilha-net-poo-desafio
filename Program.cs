using DesafioPOO.Models;

    Console.WriteLine("Smartphone Iphone");
    Iphone iphone1 = new Iphone("123456789", "iPhone X", "IMEI123", 64);
    iphone1.Ligar();
    iphone1.ReceberLigacao();
    iphone1.InstalarAplicativo("Instagram");

    Console.WriteLine("\nSmartphone Nokia");
    Nokia nokia1 = new Nokia("111222333", "Nokia 3310", "IMEI456", 128);
    nokia1.Ligar();
    nokia1.ReceberLigacao();
    nokia1.InstalarAplicativo("Twitter");