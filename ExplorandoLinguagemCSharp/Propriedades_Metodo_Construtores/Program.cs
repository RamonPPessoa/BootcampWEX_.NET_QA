using Propriedades_Metodo_Construtores.Models;



Pessoa p1 = new Pessoa();

p1.Nome = "Fernanda";
p1.Sobrenome = "Silva";


Pessoa p2 = new Pessoa();

p2.Nome = "Camila";
p2.Sobrenome = "Santos";

Curso cursoDeIdioma = new Curso();
cursoDeIdioma.Nome = "Ingês";
cursoDeIdioma.Alunos = new List<Pessoa>();

cursoDeIdioma.AdicionarAluno(p1);
cursoDeIdioma.AdicionarAluno(p2);
cursoDeIdioma.ListarAlunos();






//Pessoa p1 = new Pessoa();

//p1.Nome = "Fernanda";
//p1.Sobrenome = "Silva";
//p1.Idade = 30;
//p1.Apresentar();