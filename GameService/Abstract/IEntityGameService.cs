using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IEntityGameService
    {
        void GetAll(List<IEntityGame> entities);
        void Add(IEntityGame entity);
        void Update(IEntityGame entity);
        void Delete(IEntityGame entity);

    }
}
