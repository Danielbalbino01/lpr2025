using System;
Console.Write("digite a quantidades de números:");
int quant = int.Parse(Console.ReadLine());
int soma = 0;
int quantidadepares = 0;
int numero;
int contador = 0;
 while(contador < quant){
 Console.Write("digite um número: ");
 numero = int.Parse(Console.ReadLine());      

   if(numero % 2 == 0)
   {
   soma += numero;
   quantidadepares++; 
   }
   contador++;
 }
 if(quantidadepares > 0){ 
 double media = (double)soma / quantidadepares;
 Console.WriteLine($"A média dos números pares é: {media}");
 }else{
   Console.WriteLine("Não foram digitados números pares.");
 }