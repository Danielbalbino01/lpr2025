using System;
int tentativa;
int tentativas = 0;
Random numAleatorio = new Random();
int valordigitado = numAleatorio.Next(1,100);
Console.WriteLine("Digite um número de 1 a 100 até acertar");

do{
Console.Write("Digite seu chute:");
tentativa = int.Parse(Console.ReadLine());
tentativas++;
if(tentativa < valordigitado){
Console.WriteLine("Chutou baixo");       
}else if (tentativa > valordigitado) {
Console.WriteLine("Chutou alto");
}else{
Console.WriteLine("Você acertou o número!!!");
Console.Write($"Esse foi seu número de tentativas: {tentativas}");     
}}
while (tentativa != valordigitado );
Console.ReadLine();




