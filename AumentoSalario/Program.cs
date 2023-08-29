/*A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo 
 * com a tabela abaixo:
    Salário	                    Percentual de Reajuste
0 - 400.00                                 15%
400.01 - 800.00                            12%
800.01 - 1200.00                           10%
1200.01 - 2000.00                          7%
Acima de 2000.00                           4%  

Leia o salário do funcionário e calcule e mostre o novo salário, 
bem como o valor de reajuste ganho e o índice reajustado, em percentual.*/

double salario,novosalario;

salario = double.Parse(Console.ReadLine());
novosalario = salario * 1.15;

if (salario > 400.00&&salario<=800.00)
{
    novosalario = salario * 1.12;
}

else if (salario > 800.00&&salario<=1200.00)
{
    novosalario = salario * 1.10;
}

else if (salario > 1200.00&&salario<=2000.00)
{
    novosalario = salario * 1.07;
}

else if (salario > 2000.00)
{
    novosalario = salario * 1.04;
}

double reajuste = novosalario - salario;

Console.WriteLine($"Novo salario: {novosalario:F2}");
Console.WriteLine($"Reajuste ganho: {reajuste:f2}");
Console.WriteLine($"Em percentual: {reajuste/salario*100:F2}%");