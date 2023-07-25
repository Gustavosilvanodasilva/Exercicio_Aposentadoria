int idade, tempo; //Variavel do tipo inteiro

Console.WriteLine("Coloque sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quanto tempo trabalhado: ");
tempo = Convert.ToInt32(Console.ReadLine());

    //Condicional se a idade corresponde para tempo de aposentadoria
if (( idade >= 65 )|| ( tempo >= 30 ))
{
    Console.WriteLine("Pode aposentar");
}
else if ((idade >= 60 && tempo >= 25))
{
    Console.WriteLine("Pode aposentar");
}
else
{
    Console.WriteLine("Não pode aposentar");
}
