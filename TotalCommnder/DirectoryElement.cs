using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder
{
    public enum DirectoryElementType { DIRECTORY, FILE }
    public class DirectoryElement
    {
        public DirectoryElementType Type { get; set; }
        public string Name { get; set; }

        public DirectoryElement(DirectoryElementType type, string name)
        {
            Type = type;
            Name = name;
        }

        public override string ToString()
        {
            int index = Name.LastIndexOf("\\")+1;
            return $"{ ((Type == DirectoryElementType.DIRECTORY) ? "<DIR> " : " ") } { Name.Substring(index) }";
        }
    }
}
