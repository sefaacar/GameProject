using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void BuyGame(IEntityGame game, IEntity player);
    }
}
