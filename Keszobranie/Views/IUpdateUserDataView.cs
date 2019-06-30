using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Views
{
   public interface IUpdateUserDataView
    {
        string UserName { get; }
        string Surname { get; }
        string Email { get; }
        string Password { get; }
        string Password2 { get; }
        event Action Update;
    }
}
