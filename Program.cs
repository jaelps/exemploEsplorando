using exemploEsplorando.Models;

//Pessoa p1 = new Pessoa();
//p1.Nome = "Jaelson";
//p1.Idade = 20;
//p1.Apresentar();

Pessoa p1 = new Pessoa();
p1.Nome = "Jaelson";


Pessoa p2 = new Pessoa();
p1.Nome = "Pereira";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

