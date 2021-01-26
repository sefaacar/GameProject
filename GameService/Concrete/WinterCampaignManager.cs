using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class WinterCampaignManager : ICampaignService
    {
        public void Add(IEntityGame game)
        {
            Console.WriteLine(game.GameName + " winter discount added");
        }

        public void Delete(IEntityGame game)
        {
            Console.WriteLine(game.GameName + " winter discount deleted");
        }

        public void Update(IEntityGame game)
        {
            Console.WriteLine(game.GameName + " winter discount updated");
        }
    }

}
