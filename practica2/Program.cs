int numSecreto = new Random(DateTime.Now.Millisecond).Next(1,40);



Console.WriteLine("Hola porfavor intente adivinar un numero del 1 al 40");
Console.WriteLine("Ingrese un numero");
int numElegido = int.Parse(Console.ReadLine());
var contInt = 0;



while 

     (numElegido > numSecreto)
    {
        Console.WriteLine("el numero es mayor, intente otra vez");
        Console.WriteLine("Ingrese un numero");
        numElegido = int.Parse(Console.ReadLine());


    }
    while (numElegido < numSecreto)
    {
        Console.WriteLine("el numero es menor , intete otra vez");
        numElegido = int.Parse(Console.ReadLine());

    }

while (numElegido == numSecreto)
{
    Console.WriteLine("felicitaciones!! haz adivinado. El numero era:" + numSecreto);
    Console.WriteLine("lo lograste");
    Console.ReadKey();
}
    
    
     
    


