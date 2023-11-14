



List<string> listaString = new List<string>();

listaString.Add("AM");

listaString.Add("AC");

listaString.Add("AP");

int contadorForeach = 0;

foreach (string item in listaString)
{
    Console.WriteLine($"Posição Nº{contadorForeach}- {item}");
    contadorForeach++;
}



/*int[] arrayInteiros = new int[3];


arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

//Array.Resize(ref arrayInteiros,arrayInteiros.Length *2);



int[] arrayInteirosDobrado = new int[arrayInteiros.Length  * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Console.WriteLine("Percorrendo com o FOR");

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição Nº{i} - {arrayInteiros[i]}");
}


/*Console.WriteLine("Percorrendo com o FOREACH");
int contadorForeach = 0;
foreach (int item in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contadorForeach}- {item}");
    contadorForeach++;

}*/