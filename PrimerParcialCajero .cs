using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int limiteRetiro = 20000, limiteTransaccion = 10000;

    Console.Write("Bienvenido al Cajero FDP Inversments. ");

    Console.WriteLine("Seleccione su banco");

    Console.WriteLine("1- FDP Inversments \n" + "2- Banco BHD León \n" + "3- Banco Popular \n" + "4- Salir");

    int banco = int.Parse(Console.ReadLine());

   if (banco == 1 || banco == 2 || banco == 3)
   {
    Console.WriteLine("Bienvenido, ¿Qué desea hacer? \n" + "1- Retiro \n" + "2- Transacción \n" + "3- Salir");

    int opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
      Console.WriteLine("Por favor, ingrese la cantidad a retirar. El limite a retirar es de "+limiteRetiro);
      int cantidadRetirar = int.Parse(Console.ReadLine());

    if (cantidadRetirar <= limiteRetiro)
    {
     Console.WriteLine("La cantidad a Retirar es de "+limiteRetiro);

      Console.WriteLine("Seleccione la distribucción deseada. \n" + "1- Billetes de 1,000 \n" + "2- Billetes de 500 \n" + "3- Billetes de 200 \n" + "4- Billetes de 100");
      int fdd = int.Parse(Console.ReadLine()); 

     if (fdd == 1)
     {
      int fddRetiro = cantidadRetirar / 1000;
      Console.WriteLine($"El monto es un total de {fddRetiro} Billetes de 1,000");
      Console.WriteLine("Gracias por utilizar el Cajero FDP Inversments");

     }
     else if (fdd == 2)
     {
      int fddRetiroDos = cantidadRetirar / 500;
      Console.WriteLine($"El monto es un total de {fddRetiroDos} Billetes de 500");
      Console.WriteLine("Gracias por utilizar el Cajero FDP Inversments");

     }
     else if (fdd == 3)
     {
      int fddRetiroTres = cantidadRetirar / 200;
      Console.WriteLine($"El monto es un total de {fddRetiroTres} Billetes de 200");
      Console.WriteLine("Gracias por utilizar el Cajero FDP Inversments");

     }
     else if (fdd == 4)
     {
      int fddRetiroCuatro = cantidadRetirar / 100;
      Console.WriteLine($"El monto es un total de {fddRetiroCuatro} Billetes de 100");
      Console.WriteLine("Gracias por utilizar el Cajero FDP Inversments");

     }
     else
     {
      Console.WriteLine("Ninguna de las opciones disponibles ha sido seleccionada, por favor seleccione una.");
     }
    }
     else if (cantidadRetirar > limiteRetiro)
     {
       Console.WriteLine("El monto ha superado el limite de Retiro, por lo tanto no puede ser dispensado");
     }
    }
      else if (opcion == 2)
      {
        Console.WriteLine($"Por favor, ingrese la cantidad a transferir. El limite a transferir es de {limiteTransaccion}");
        int cantidadTransferir = int.Parse(Console.ReadLine());

      if (cantidadTransferir <= limiteTransaccion)
      {
        Console.WriteLine($"La cantidad a Transferir es de {cantidadTransferir}");
        int cuentaTransiccion;
      do
      {
        Console.WriteLine("Ingrese el número de cuenta a transferir");

        cuentaTransiccion = int.Parse(Console.ReadLine());

        Console.WriteLine($"Verificando el número de cuenta: {cuentaTransiccion}...");

      if (cuentaTransiccion > 999999999)
      {
        Console.WriteLine("El número de cuenta introducido es invalido");
      }
      }while (cuentaTransiccion > 999999999);

      if (cuentaTransiccion <= 999999999)
      {
        Console.WriteLine("Valido");
        Console.WriteLine("¿Seguro qué desea realizar esta transacción? \n" + "Si \n" + "No");
        string respuesta = Console.ReadLine();
      if (respuesta == "Si" || respuesta == "si")
      {
        Console.WriteLine("La transicción ha sido exitosa");
      }
      else if (respuesta == "No" || respuesta == "no")
      {
        Console.WriteLine("Gracias por utilizar el Cajero FDP Inversments");
      }
      }
      }
      }
      else if (opcion == 3)
      {
        Console.WriteLine("Gracias por utilizar el Cajero FDP Inversments");
      }
  }
 }
}