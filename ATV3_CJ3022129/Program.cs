

using System.ComponentModel.Design;

float b1;
float b2;
float b3;
float b4;
float nota;


Console.WriteLine("Digite a sua nota no primeiro bimestre: ");
b1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua nota no segundo bimestre: ");
b2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a sua nota no terceiro bimestre:");
b3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua nota no quarto bimestre:");
b4 = float.Parse(Console.ReadLine());

nota= (b1 + b2+ b3 +b4) /4;
if (nota <= 5.99)
{
    Console.WriteLine("O aluno está reprovado");
  
}


else if (nota >= 6) 
{
    Console.WriteLine("O aluno foi aprovado");
}

