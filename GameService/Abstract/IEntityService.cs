using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IEntityService
    {
        void GetAll(List<IEntity> entities);
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
