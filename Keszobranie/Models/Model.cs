using Keszobranie.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Models
{
    public class Model
    {
        void auth()
        {
            var dataAccess = DBConnection.getInstance();

           // dataAccess.ExecuteCommand(uint.Parse(DBResources.port), DBResources.server, DBResources.user, DBResources.password, DBResources.database);
        }
    }
}
