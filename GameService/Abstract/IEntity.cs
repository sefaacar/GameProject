using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }
        string FirstName { get; set; }
    }
}
