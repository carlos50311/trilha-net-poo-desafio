using DesafioPOO.Models;

Iphone iphone = new("123456789", "Iphone 12", "1111111", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("instagram");

Nokia nokia = new("987654321", "Nokia 331o", "2222222", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");