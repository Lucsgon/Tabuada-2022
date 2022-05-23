double numero, produto, contador;

Console.Clear();
Console.WriteLine("----- Tabuada -----\n");

Console.Write("Insira o número: ");
numero = Convert.ToDouble(Console.ReadLine());

if (numero <= 0)
{

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nNúmero inválido.");
    Console.ResetColor();
}
else
{
   
    Console.Clear();
    
    Console.WriteLine($"- Tabuada do número {numero} -");

    contador = 0;
    while (contador <= 10)
    {
        produto = numero * contador;
        Console.WriteLine($"{numero} x {contador} = {produto}");
        
        
        contador++;
    }
}


Console.Write("\nPressione uma tecla para finalizar... ");
Console.ReadKey();


Console.Clear();