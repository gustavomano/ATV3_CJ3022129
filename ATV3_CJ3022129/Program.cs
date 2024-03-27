

int n;

Console.WriteLine("Digite um número");
n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine("o numero é par");


}
else
{
    Console.WriteLine("o numero é impar");

}

//Questão 2

int lad1, lad2, lad3;

Console.WriteLine("digite o 1 lado do triangulo");
lad1 = int.Parse(Console.ReadLine());

Console.WriteLine(" digite o 2 lado triangulo");
lad2 = int.Parse(Console.ReadLine());

Console.WriteLine(" digite o 3 lafo do triangulo");
lad3 = int.Parse(Console.ReadLine());

if ((lad1 == lad2) && (lad2 == lad3))
{
    Console.WriteLine(" triangulo equilatero");
};
if ((lad1 == lad2) && (lad2 == lad3) && (lad1 == lad3))
{
    Console.WriteLine(" trianguo isoeles");
}

if ((lad1 != lad2) && ((lad2 != lad3) && (lad1 != lad3)))
{
    Console.WriteLine(" triangulo escaleno");

}

// questão 3

int nc, n1;

Console.WriteLine(" qual numero estou pensand0 entre 1 a 100?");
n1 = int.Parse(Console.ReadLine());


nc = new Random().Next(1, 100);

if ((nc > n1))
{
    Console.WriteLine("O numero é menor");
}

if ((nc < n1))
{
    Console.WriteLine("O numero é maior");
}

if ((n1 == nc))
{
    Console.WriteLine("VOCÊ VENCEU!");

}

// questão 4

int usu, sen, sen2;

Console.WriteLine("digite o seu usuario");
usu = int.Parse(Console.ReadLine());

Console.WriteLine("digite sua senha (sua senha deve ser seu usuario mais uma sequencia numérica");
sen = int.Parse(Console.ReadLine());

sen2 = usu & sen;

if ((sen2 == sen2))
{
    Console.WriteLine("ACESSO CONCEDIDO");
}
else
{
    Console.WriteLine("ACESSO NEGADO");
}

// questão 5

int nota;

Console.WriteLine("digite sua nota de 0 a 100");
nota = int.Parse(Console.ReadLine());

if ((nota >= 90))
{
    Console.WriteLine(" Sua nota é A");
}

if ((nota >= 80) && (nota <= 89))
{
    Console.WriteLine(" Sua nota é B");
}

if ((nota >= 70) && (nota <= 79))
{
    Console.WriteLine(" Sua nota é C");
}

if ((nota >= 60) && (nota <= 69))
{
    Console.WriteLine("Sua nota é D");
}

if ((nota < 60))
{
    Console.WriteLine(" Sua nota é F");

}

//questao 6 

int resp, rcomp;

Console.WriteLine("digite 1 para pedra,2 para papel e 3 para de tesoura");
resp = int.Parse(Console.ReadLine());

rcomp = new Random().Next(1, 3);

if ((resp == 1) && (rcomp == 2))
{
    Console.WriteLine("VOCÊ PERDEU");
}

if ((resp == 1) && (rcomp == 1))
{
    Console.WriteLine("EMPATADO");
}

if ((resp == 1) && (rcomp == 3))
{
    Console.WriteLine("VOCÊ VENCEU");
}

if ((resp == 2) && (rcomp == 2))
{
    Console.WriteLine(" EMPATADO");
}

if ((resp == 2) && (rcomp == 1))
{
    Console.WriteLine(" VOCÊ VENCEU");
}

if ((resp == 2) && (rcomp == 3))
{
    Console.WriteLine(" VOCÊ PERDEU");
}

if ((resp == 3) && (rcomp == 1))
{
    Console.WriteLine(" VOCÊ PERDEU");
}

if ((resp == 3) && (rcomp == 2))
{
    Console.WriteLine(" VOCÊ VENCEU");
}

if ((resp == 3) && (rcomp == 3))
{
    Console.WriteLine(" EMPATADO");
}

//questão 7

int vlrcomp, vlrf;

Console.WriteLine("digite o valor de sua compra");
vlrcomp = int.Parse(Console.ReadLine());

if ((vlrcomp >= 100))
{
    vlrf = vlrcomp - (vlrcomp * 10 / 100);
    Console.WriteLine("O valor com o desconto é", vlrf);
}

if ((vlrcomp >= 200))
{
    vlrf = vlrcomp - (vlrcomp * 20 / 100);
    Console.WriteLine("O valor com o desconto é", vlrf);
}

if ((vlrcomp >= 300))
{
    vlrf = vlrcomp - (vlrcomp * 30 / 100);
    Console.WriteLine("o valor da compra com o desconto é", vlrf);
}

if ((vlrcomp >= 400))
{
    vlrf = vlrcomp - (vlrcomp * 40 / 100);
    Console.WriteLine(" o valor da compra com o desconto é", vlrf);
}

// questão 8

float peso, alt, imc;

Console.WriteLine(" Digite seu pesoem KG");
peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura");
alt = float.Parse(Console.ReadLine());

imc = peso / (alt * alt);

if (imc < 18.5f)
{
    Console.WriteLine("abaixo do peso");
}
if (imc <= 24.9f)
{
    Console.WriteLine("peso normal");
}
if (imc <= 34.9f)
{
    Console.WriteLine(" obesidade grau 1");
}
if (imc <= 39.9f)
{
    Console.WriteLine("obsedade grau 2");
}
if (imc > 39.9f)
{
    Console.WriteLine("obsedade grau 3");
}
