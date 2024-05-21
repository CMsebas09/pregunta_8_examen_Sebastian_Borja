using System;

// Definición de la interfaz IPais
interface IPais
{
    string ColorBandera();
    string Tamaño();
    string IdiomaOficial();
}

// Implementación de la interfaz para Ecuador
class Ecuador : IPais
{
    public string ColorBandera()
    {
        return "Amarillo, Azul y Rojo";
    }

    public string Tamaño()
    {
        return "283,561 km²";
    }

    public string IdiomaOficial()
    {
        return "Español";
    }
}

// Implementación de la interfaz para Brasil
class Brasil : IPais
{
    public string ColorBandera()
    {
        return "Verde y Amarillo";
    }

    public string Tamaño()
    {
        return "8.51 millones km²";
    }

    public string IdiomaOficial()
    {
        return "Portugués";
    }
}

// Implementación de la interfaz para Andorra
class Andorra : IPais
{
    public string ColorBandera()
    {
        return "Azul, Amarillo y Rojo";
    }

    public string Tamaño()
    {
        return "468 km²";
    }

    public string IdiomaOficial()
    {
        return "Catalán";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de las clases que implementan la interfaz IPais
        IPais ecuador = new Ecuador();
        IPais brasil = new Brasil();
        IPais andorra = new Andorra();

        // Mostrar información de los países
        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());
        Console.WriteLine("Idioma de Brasil: " + brasil.IdiomaOficial());
    }
}
