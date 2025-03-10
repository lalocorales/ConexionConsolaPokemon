using System;

namespace Conexion
{
    class Program
    {
        static void Main()
        {
            Conexion conexion = new Conexion();
            PokemonEntrenador p = new PokemonEntrenador();
            IPokemonEntrenadorRepository repository = new PokemonEntrenadorRepository(conexion);

            while (true)
            {
                Console.WriteLine("\n🎮 MENU POKEDEX 🎮");
                Console.WriteLine("1️⃣ Agregar Entrenador");
                Console.WriteLine("2️⃣ Mostrar Entrenadores");
                Console.WriteLine("3️⃣ Actualizar Entrenador");
                Console.WriteLine("4️⃣ Eliminar Entrenador");
                Console.WriteLine("5️⃣ Salir");
                Console.Write("👉 Elige una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dame id:");
                        p.IdEntrenador = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nombre");
                         p.NombreEntrenador = Console.ReadLine();
                        Console.WriteLine("Ciudad");
                        p.Ciudad = Console.ReadLine();
                        Console.WriteLine("Pokemon");
                        p.Pokemon = Console.ReadLine();
                        Console.WriteLine("Tipo");
                        p.Tipo = Console.ReadLine();
                        Console.WriteLine("nivel");
                        p.Nivel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Movimiento 1");
                        p.Movimiento1 = Console.ReadLine();
                        Console.WriteLine("Movimiento 2");
                        p.Movimiento2 = Console.ReadLine();
                        Console.WriteLine("Movimiento 3");
                        p.Movimiento3 = Console.ReadLine();
                        Console.WriteLine("Movimiento 4");
                        p.Movimiento4 = Console.ReadLine();
                        Console.WriteLine("LigaGanada");
                        p.LigaGanada = Console.ReadLine();

                        repository.Crear(new PokemonEntrenador(p.IdEntrenador,p.NombreEntrenador,p.Ciudad,p.Pokemon,p.Tipo,p.Nivel,p.Movimiento1,p.Movimiento2,p.Movimiento3,p.Movimiento4,p.LigaGanada));
                        
                        break;
                    case 2:
                        repository.Leer().ForEach(e => Console.WriteLine($"{e.IdEntrenador} - {e.NombreEntrenador} - {e.Pokemon}"));
                        break;
                    case 3:
                        Console.WriteLine("Dame id:");
                        p.IdEntrenador = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nombre");
                        p.NombreEntrenador = Console.ReadLine();
                        Console.WriteLine("Ciudad");
                        p.Ciudad = Console.ReadLine();
                        Console.WriteLine("Pokemon");
                        p.Pokemon = Console.ReadLine();
                        Console.WriteLine("Tipo");
                        p.Tipo = Console.ReadLine();
                        Console.WriteLine("nivel");
                        p.Nivel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Movimiento 1");
                        p.Movimiento1 = Console.ReadLine();
                        Console.WriteLine("Movimiento 2");
                        p.Movimiento2 = Console.ReadLine();
                        Console.WriteLine("Movimiento 3");
                        p.Movimiento3 = Console.ReadLine();
                        Console.WriteLine("Movimiento 4");
                        p.Movimiento4 = Console.ReadLine();
                        Console.WriteLine("LigaGanada");
                        p.LigaGanada = Console.ReadLine();

                        repository.Actualizar(new PokemonEntrenador(p.IdEntrenador, p.NombreEntrenador, p.Ciudad, p.Pokemon, p.Tipo, p.Nivel, p.Movimiento1, p.Movimiento2, p.Movimiento3, p.Movimiento4, p.LigaGanada));

                        break;
                    case 4:
                        Console.WriteLine("Dame el ID del entreador a Eliminar:");
                        repository.Eliminar(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 5:
                        return;
                }
            }
        }
    }

}
