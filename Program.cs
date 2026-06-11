// Escreva a mesnsagem "informe um numero: "
Console.Write("informe um numero: ");
//Cria a variabelQueSalvaUmNumero,
//leia o que o usuário digitar
// e tranforma o valor lido de texto para o inteiro (int.Parse)
int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine()!);

//verifica se o valor de variavelQueSalvaUmNumero é par
if(variavelQueSalvaUmNumero % 2 ==0) {
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é par");
}   else {Console.WriteLine($"Número {variavelQueSalvaUmNumero} é ímpar"); }



    
   