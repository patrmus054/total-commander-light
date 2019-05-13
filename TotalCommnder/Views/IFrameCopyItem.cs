using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder
{
    public interface IFrameCopyItem
    {
        List<DirectoryElement> Directories { set; }
        DirectoryElement GetSelectedItem { get; }
        event Action Commit;
    }
}
