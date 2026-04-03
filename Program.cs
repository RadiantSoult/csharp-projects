using System;
class Program 
{ 
    static void Main() 
    { 
        Console.WriteLine("Escribe tu nombre aqui: "); 
        string name = Console.ReadLine(); 
        
        Console.WriteLine("Escribe tu edad aqui: "); 
        int age;
        if (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Edad inválida");
            return;
        }
        
        Console.WriteLine("Escribe tu pais aqui: "); 
        string country = Console.ReadLine(); 

        if (name.ToLower() == "jonathan")
        { 
            Console.WriteLine("Acceso VIP");
             
        } 
        else 
        { 
            Console.WriteLine("Hola " + name); 
        } 

        if (age >= 18) 
        { 
            Console.WriteLine("Mayor de edad"); 
        } 
        else 
        { 
            Console.WriteLine("Menor de edad"); 
        } 
        
        if (country == "Colombia") 
        { 
            Console.WriteLine("El mejor pais!"); 
        } 
        else 
        { 
            Console.WriteLine("No se que pais es ese, buscando..."); 
        } 
    } 
}