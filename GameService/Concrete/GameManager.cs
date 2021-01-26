using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IEntityGameService
    {
        public void Add(IEntityGame entity)
        {
            Console.WriteLine("Added new game : " + entity.GameName);
        }

        public void Delete(IEntityGame entity)
        {
            Console.WriteLine("Deleted game : " + entity.GameName);
        }

        public void GetAll(List<IEntityGame> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName);
            }
        }

        public void Update(IEntityGame entity)
        {
            Console.WriteLine("Updated game: " + entity.GameName);
        }
    }
}
