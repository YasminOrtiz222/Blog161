using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otamix1.Models
{
    public class User : IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }
        public virtual ICollection<Mensagem> Mensagems { set; get;}


    }
}
