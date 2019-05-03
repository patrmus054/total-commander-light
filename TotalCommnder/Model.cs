using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommnder
{
    class Model
    {
        public List<DirectoryElement> LoadPathFiles(string path)
        {
            List<DirectoryElement> directoryElements = new List<DirectoryElement>();
            //DirectoryElement[] directoryElements;
            //directoryElements = new DirectoryElement[];
            IEnumerable<string> files = Enumerable.Empty<string>();
            IEnumerable<string> directories = Enumerable.Empty<string>();

            try
            {
                // The test for UnauthorizedAccessException.
                var permission = new FileIOPermission(FileIOPermissionAccess.PathDiscovery, path);
                permission.Demand();

                files = Directory.GetFiles(path);
                directories = Directory.GetDirectories(path);
            }
            catch
            {
                return directoryElements;
            }

            foreach (var item in directories)
            {
                directoryElements.Add(new DirectoryElement(DirectoryElementType.DIRECTORY, item.ToString()));
            }

            foreach (var item in files)
            {
                directoryElements.Add(new DirectoryElement(DirectoryElementType.FILE, item.ToString()));
            }

          

            return directoryElements;
        }


        public void Delete(string path)
        {

        }
        public void Copy(string path)
        {

        }
        public void Move(string path)
        {

        }
        public void NewFolder(string path)
        {

        }
    }
}
