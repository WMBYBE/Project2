﻿//Game model for creating Game objects
namespace Project2.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ReleaseDate { get; set; }
        public string? Developer { get; set; }
        public int? MetaCritic { get; set; }
    }
}
