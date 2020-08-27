using System;
using System.ComponentModel.DataAnnotations;

namespace webapicore.Models
{
    public class User 
    {
        public Guid UserId {get;set;} = Guid.NewGuid();

        [MaxLength(100)]
        public string Name {get;set;}
        public string LastName {get;set;}
        public bool Active {get;set;} = true;
    }
}