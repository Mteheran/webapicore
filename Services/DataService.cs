using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapicore.Models;

namespace webapicore.Services
{
    public class DataService : IDataService
    {
        public List<User> Users { get; set; }

        public DataService(int AmountOfElements)
        {
            Users = new List<User>(); 
            for(var i=0; i<AmountOfElements; i++)
            {
                var random  = new Random();
                Users.Add(new User() { Name = "Name" + random.Next(1000), LastName = "LastName" + random.Next(1000) });            
            }
        }

        public List<User> GetUsers()
        {
            return Users;
        }

        public void SaveUser(User user)
        {
            Users.Add(user);
        }

        public User GetUserById(string id)
        {
            Guid userId = new Guid();

            Guid.TryParse(id,out userId);

            return Users.FirstOrDefault(p=> p.UserId == userId);
        }
    }
}