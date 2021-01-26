using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {


            IEntity player1 = new Customer { Id = 1, FirstName = "Nazım", LastName = "Marul", DateOfBirth = new DateTime(1999, 9, 2), NationalityId = "12345678901" };
            IEntity player2 = new Customer { Id = 2, FirstName = "Emre", LastName = "Yılmaz", DateOfBirth = new DateTime(1994, 7, 3), NationalityId = "59124853215" };
            IEntity player3 = new Customer { Id = 3, FirstName = "Zeynep", LastName = "Çakır", DateOfBirth = new DateTime(1996, 5, 8), NationalityId = "15482452565" };

            IEntityService customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Add(player1);
            customerManager.Add(player2);
            customerManager.Add(player3);

            Console.WriteLine("*****************************\nAllPlayer");


            List<IEntity> players = new List<IEntity> { player1, player2, player3 };
            customerManager.GetAll(players);

            Console.WriteLine("*****************************");


            IEntityGame game1 = new Game { Id = 1, GameName = "GTA5", GamePrice = 85, Stock = 1000 };
            IEntityGame game2 = new Game { Id = 2, GameName = "Pubg", GamePrice = 49, Stock = 500 };
            IEntityGame game3 = new Game { Id = 3, GameName = "Valorant", GamePrice = 0, Stock = 8000 };

            IEntityGameService gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            Console.WriteLine("*****************************\nAll Games");


            List<IEntityGame> games = new List<IEntityGame> { game1, game2, game3 };
            gameManager.GetAll(games);
            Console.WriteLine("*****************************");


            ISaleService saleEpic = new EpicGameSaleManager();
            saleEpic.BuyGame(game1, player2);

            Console.WriteLine("*****************************");




            ICampaignService newYearCampaign = new NewYearCampaignManager();
            newYearCampaign.Add(game1);

            Console.WriteLine("*****************************");


            ICampaignService winterCampaign = new WinterCampaignManager();
            winterCampaign.Add(game2);
            Console.WriteLine("*****************************");


        }
    }
}
