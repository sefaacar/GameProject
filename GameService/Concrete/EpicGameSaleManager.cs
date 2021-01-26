using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class EpicGameSaleManager : ISaleService
    {
        public void BuyGame(IEntityGame game, IEntity player)
        {
            Console.WriteLine(" player" + player.FirstName + " buys " + game.GameName + " game via Epic Game");
        }
    }
}
