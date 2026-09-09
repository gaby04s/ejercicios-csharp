using System;

class ClasificadorNumeros
{
    static void Main()
    {
        Console.WriteLine("=== CLASIFICADOR DE NÚMEROS ===\n");
        
        bool continuar = true;
        
        while (continuar)
        {
            Console.WriteLine("\nOpciones disponibles:");
            Console.WriteLine("1. Par o impar");
            Console.WriteLine("2. Positivo, negativo o cero");
            Console.WriteLine("3. Es múltiplo de 5");
            Console.WriteLine("4. Es un número de 2 dígitos");
            Console.WriteLine("5. Salir");
            Console.Write("\nSelecciona una opción (1-5): ");
            
            string opcion = Console.ReadLine();
            
            if (opcion == "5")
            {
                Console.WriteLine("¡Hasta luego!");
                continuar = false;
                break;
            }
            
            if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                continue;
            }
            
            Console.Write("Ingresa un número: ");
            
            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                continue;
            }
            
            switch (opcion)
            {
                case "1":
                    ClasificarParImpar(numero);
                    break;
                case "2":
                    ClasificarPositivoNegativoCero(numero);
                    break;
                case "3":
                    VerificarMultiploDe5(numero);
                    break;
                case "4":
                    VerificarDosDigitos(numero);
                    break;
            }
            
            Console.Write("\n¿Deseas continuar? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s" && respuesta != "si")
            {
                continuar = false;
                Console.WriteLine("¡Hasta luego!");
            }
        }
    }
    
    static void ClasificarParImpar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"✓ {numero} es un número PAR");
        }
        else
        {
            Console.WriteLine($"✓ {numero} es un número IMPAR");
        }
    }
    
    static void ClasificarPositivoNegativoCero(int numero)
    {
        if (numero > 0)
        {
            Console.WriteLine($"✓ {numero} es un número POSITIVO");
        }
        else if (numero < 0)
        {
            Console.WriteLine($"✓ {numero} es un número NEGATIVO");
        }
        else
        {
            Console.WriteLine($"✓ {numero} es CERO");
        }
    }
    
    static void VerificarMultiploDe5(int numero)
    {
        if (numero % 5 == 0)
        {
            Console.WriteLine($"✓ {numero} ES un múltiplo de 5");
        }
        else
        {
            Console.WriteLine($"✓ {numero} NO es un múltiplo de 5");
        }
    }
    
    static void VerificarDosDigitos(int numero)
    {
        int numeroAbsoluto = Math.Abs(numero);
        if (numeroAbsoluto >= 10 && numeroAbsoluto <= 99)
        {
            Console.WriteLine($"✓ {numero} ES un número de 2 dígitos");
        }
        else
        {
            Console.WriteLine($"✓ {numero} NO es un número de 2 dígitos");
        }
    }
}
