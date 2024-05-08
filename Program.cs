using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone

var nokia = new Nokia("1254", "nokia", "1208", 200);
var iphone = new Iphone("1111", "hipone", "20", 100);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Maia");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Candy Crush");