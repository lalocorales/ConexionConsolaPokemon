using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class PokemonEntrenador
    {

        public PokemonEntrenador() { }
        public PokemonEntrenador(int idEntrenador, string? nombreEntrenador, string? ciudad, string? pokemon, string? tipo, int nivel, string? movimiento1, string? movimiento2, string? movimiento3, string? movimiento4, string? ligaGanada)
        {
            IdEntrenador = idEntrenador;
            NombreEntrenador = nombreEntrenador;
            Ciudad = ciudad;
            Pokemon = pokemon;
            Tipo = tipo;
            Nivel = nivel;
            Movimiento1 = movimiento1;
            Movimiento2 = movimiento2;
            Movimiento3 = movimiento3;
            Movimiento4 = movimiento4;
            LigaGanada = ligaGanada;
        }

        public int IdEntrenador { get; set; }
        public string ?NombreEntrenador { get; set; }
        public string? Ciudad { get; set; }
        public string? Pokemon { get; set; }
        public string? Tipo { get; set; }
        public int Nivel { get; set; }
        public string? Movimiento1 { get; set; }
        public string? Movimiento2 { get; set; }
        public string? Movimiento3 { get; set; }
        public string? Movimiento4 { get; set; }
        public string? LigaGanada { get; set; }
    }

}
