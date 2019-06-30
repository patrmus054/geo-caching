using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keszobranie.Views
{
    interface INewCacheView
    {
        string name { get; }
        string description { get; }
        string hint { get; }
        event Action addNewCache;
        event Action onExit;
    }
}
