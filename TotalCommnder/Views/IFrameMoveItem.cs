using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder
{
    public interface IFrameMoveItem
    {
        List<DirectoryElement> Directories { set; }
        string getCurrentElement { get; }
        event Action call;
    }
}
