using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class NewYearCampaignManager : ICampaignService
    {
        public void Add(IEntityGame game)
        {
            Console.WriteLine(game.GameName + " new year discount added");
        }

        public void Delete(IEntityGame game)
        {
            Console.WriteLine(game.GameName + " new year discount deleted");
        }

        public void Update(IEntityGame game)
        {
            Console.WriteLine(game.GameName + " new year discount update");
        }
    }
}
