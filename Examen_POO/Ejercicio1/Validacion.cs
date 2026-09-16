using System;

class Validacion
{
    // Validar que el nombre no esté vacío y contenga solo letras y espacios
    public static bool ValidarNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("❌ El nombre no puede estar vacío.");
            return false;
        }
        
        foreach (char c in nombre)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                Console.WriteLine("❌ El nombre solo debe contener letras y espacios.");
                return false;
            }
        }
        
        return true;
    }
    
    // Validar que la opción sea un número entero válido dentro del rango
    public static bool ValidarOpcion(string input, int minimo, int maximo, out int opcion)
    {
        opcion = 0;
        
        if (!int.TryParse(input, out opcion))
        {
            Console.WriteLine($"❌ Debes ingresar un número válido entre {minimo} y {maximo}.");
            return false;
        }
        
        if (opcion < minimo || opcion > maximo)
        {
            Console.WriteLine($"❌ La opción debe estar entre {minimo} y {maximo}.");
            return false;
        }
        
        return true;
    }
    
    // Validar que la cantidad sea un número positivo
    public static bool ValidarCantidad(string input, out int cantidad)
    {
        cantidad = 0;
        
        if (!int.TryParse(input, out cantidad))
        {
            Console.WriteLine("❌ Debes ingresar un número válido.");
            return false;
        }
        
        if (cantidad <= 0)
        {
            Console.WriteLine("❌ La cantidad debe ser mayor a 0.");
            return false;
        }
        
        return true;
    }
}
