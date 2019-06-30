using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Views
{
    public interface ILoginView
    {
        string Email { get; }
        string password { get; }

        event Action authorize;
        event Action registerNewAccount;
        event Action onExit;
    }
}
