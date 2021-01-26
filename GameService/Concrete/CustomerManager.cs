using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CustomerManager : IEntityService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Add(IEntity entity)
        {
            if (_customerCheckService.CheckIfRealPerson(entity))
            {
                Console.WriteLine("Added new player: " + entity.FirstName);
            }
            else
            {
                Console.WriteLine(entity.FirstName + " has not been added");
            }
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Player deleted : " + entity.FirstName);
        }

        public void GetAll(List<IEntity> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine(player.FirstName);
            }
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Player updated : " + entity.FirstName);
        }
    }
}
