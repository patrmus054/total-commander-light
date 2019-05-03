using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder
{
    public interface IView
    {
        IPanelView PanelLeft { get; }
        IPanelView PanelRight { get; }
        event Action move;

    }
}
