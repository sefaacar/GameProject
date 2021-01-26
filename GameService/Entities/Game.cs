using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game : IEntityGame
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        public int Discount { get; set; }
        public int Stock { get; set; }

    }
}
