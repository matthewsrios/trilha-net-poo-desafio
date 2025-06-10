using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone(numero: "901919119", IMEI: "838383939999999933", memoria: 2, modelo: "PRO 15");
Smartphone nokia = new Nokia(numero: "929929229", IMEI: "9393939393993000", memoria: 4, modelo: "nokia 1100");

iphone.InstalarAplicativo("Tinder");
iphone.ReceberLigacao();
iphone.Ligar();

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Waze");