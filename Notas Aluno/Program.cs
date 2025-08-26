string nomeAluno = "Bianca Botelho Develis";
string bimestre1 = "1° Bimestre";
string bimestre2 = "2° Bimestre";
string bimestre3 = "3° Bimestre";
string bimestre4 = "4° Bimestre";

int atividadesnota1 = 8;
int atividadesnota2 = 7;
int atividadesnota3 = 6;
int atividadesnota4 = 7;

int notaprova1 = 7;
int notaprova2 = 6;
int notaprova3 = 8;
int notaprova4 = 9;

int notasatividades = atividadesnota1 + atividadesnota2 + atividadesnota3 + atividadesnota4;

int notasprovas = notaprova1 + notaprova2 + notaprova3 + notaprova4;

decimal gradeNotas = (atividadesnota1 + atividadesnota2 + atividadesnota3 + atividadesnota4 + notaprova1 + notaprova2 + notaprova3 + notaprova4) / 8m;

int nota1 = (int)gradeNotas;
int nota2 = (int)(gradeNotas * 10) % 10;
int nota3 = (int)(gradeNotas * 100) % 10;

Console.WriteLine($"Boletim Escolar - Aluno: {nomeAluno}");
Console.WriteLine($"---------------------------------");
Console.WriteLine($"| Bimestre    | Ativ.| Provas |"); 
Console.WriteLine($"---------------------------------");
Console.WriteLine($"| {bimestre1} |  {atividadesnota1}   |   {notaprova1}    |");
Console.WriteLine($"| {bimestre2} |  {atividadesnota2}   |   {notaprova2}    |");
Console.WriteLine($"| {bimestre3} |  {atividadesnota3}   |   {notaprova3}    |");
Console.WriteLine($"| {bimestre4} |  {atividadesnota4}   |   {notaprova4}    |");
Console.WriteLine($"---------------------------------");
Console.WriteLine($"| Total       |  {notasatividades}  |   {notasprovas}   |                |");
Console.WriteLine($"---------------------------------");
Console.WriteLine($"Média Final: {nota1},{nota2}{nota3}");
if (gradeNotas >= 7)
{
    Console.WriteLine("Status: Aprovado(a) Parabéns!");
}
else
{
    Console.WriteLine("Status: Reprovado");
}






