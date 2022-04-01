﻿namespace BlazorAppProjectMovie.Client.Shared.Entidades
{
    public class GeneroPelicula
    {
        public int PeliculaId { get; set; }
        public string GeneroId { get; set; }
        public Genero Genero { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}