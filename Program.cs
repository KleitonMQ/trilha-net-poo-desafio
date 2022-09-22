using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone meuIphone = new Iphone("98765421","modelo-x", "9999999", 128);
Nokia meuNokia = new Nokia("123456789","modelo-y", "3333333", 128);

Console.WriteLine("Testes realizandos na classe Iphone");
meuIphone.Ligar();
meuIphone.ReceberLigacao(123456789);
meuIphone.InstalarAplicativo("Facebook");
Console.WriteLine("Encerrando testes Iphone \n\n");
Console.WriteLine("Testes realizandos na classe Nokia");
meuNokia.Ligar();
meuNokia.ReceberLigacao(98765421);
meuNokia.InstalarAplicativo("Instagram");
Console.WriteLine("Encerrando testes Nokia");
