using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapicore.Models;

namespace webapicore.Services
{
    public interface IDataService
    {
        List<User> Users  {get;set;}
        List<User> GetUsers();
        void SaveUser(User user);
        User GetUserById(string id);

    }
}