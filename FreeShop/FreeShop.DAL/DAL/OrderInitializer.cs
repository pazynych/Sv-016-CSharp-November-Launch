using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

using FreeShop.DAL.Models;

namespace FreeShop.DAL.DAL
{
    public class OrderInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<OrderContext>
    {

        protected override void Seed(OrderContext context)
        {
            var users = new List<User>
            {
                new User{ UserID = 1 ,NickName="Arexol"         ,FirstName="Alex", LastName="Serkin",Email = "E@A.ru",Region = "Sevastopol",Role = "Young Padavan "},
                new User{ UserID = 2 ,NickName="bsesie71"       ,FirstName=" x"  , LastName="S"     ,Email = "E@A.ru",Region = "Sevastopol",Role = "Young Padavan "},
                new User{ UserID = 3 ,NickName="intsiren"       ,FirstName="buuu", LastName="www"   ,Email = "E@A.ru",Region = "Sevastopol",Role = "Young Padavan "},
                new User{ UserID = 4 ,NickName="igor.aka.ky7m"  ,FirstName="Igor", LastName="II    ",Email = "E@A.ru",Region = "Sevastopol",Role = "Obi van kanobi"},
                new User{ UserID = 5 ,NickName="SoftServe Ita"  ,FirstName="AAA ", LastName="BB    ",Email = "E@A.ru",Region = "Sevastopol",Role = "Dark Vaider   "}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }

    }
}