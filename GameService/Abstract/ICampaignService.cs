using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(IEntityGame game);
        void Delete(IEntityGame game);
        void Update(IEntityGame game);
    }
}
