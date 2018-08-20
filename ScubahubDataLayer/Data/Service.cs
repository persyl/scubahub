using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScubahubDataLayer.Data
{
    public class Service
    {
        public void AddDiver(string name)
        {
            var context = new EntityDemoDb();
            var diver = new Divers
            {
                Name = name,
                Date = DateTime.Now
            };
            context.Divers.Add(diver);
            context.SaveChanges();
        }
    }
}
