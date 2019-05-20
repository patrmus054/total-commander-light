using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotalCommnder.Presenters;

namespace TotalCommnder
{
    public class Model
    {
        public List<DirectoryElement> LoadPathFiles(string path)
        {
            List<DirectoryElement> directoryElements = new List<DirectoryElement>();
            IEnumerable<string> files = Enumerable.Empty<string>();
            IEnumerable<string> directories = Enumerable.Empty<string>();

            try
            {
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

        public List<DirectoryElement> LoadPathfolders(string path)
        {
            List<DirectoryElement> folders = new List<DirectoryElement>();

            IEnumerable<string> directories = Enumerable.Empty<string>();
            directories = Directory.GetDirectories(path);

            foreach(var item in directories)
            {
                folders.Add(new DirectoryElement(DirectoryElementType.DIRECTORY, item.ToString()));
            }

            return folders;
        }

        internal void Move(DirectoryElement source, string msg)
        {
            int index = source.Name.LastIndexOf("\\");
            string leftName = source.Name.Substring(index);
            try
            {
                if (source.Type == DirectoryElementType.FILE)
                {
                    File.Move(source.Name, msg);
                }
                else
                {
                    
                    Directory.Move(source.Name, msg);
                   
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Move(DirectoryElement left, DirectoryElement right)
        {
            int index = left.Name.LastIndexOf("\\");
            string leftName = left.Name.Substring(index);
            try
            {
                if (left.Type == DirectoryElementType.FILE)
                {
                    File.Move(left.Name, right.Name + leftName);
                }
                else
                {
                    if (right.Type == DirectoryElementType.DIRECTORY)
                    {
                        Directory.Move(left.Name, right.Name);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Delete(DirectoryElement name)
        {
            if(name != null) { 
                string path = name.Name;

                if(File.Exists(path))
                {
                    File.Delete(path);
                }
                else
                {
                Directory.Delete(path);
                }
            }
        }
        public void Copy(DirectoryElement left, string right)
        {
            //TODO: case file exist exeption handling 
            if (left.Type == DirectoryElementType.FILE) { File.Copy(left.Name, $"{right}\\{Path.GetFileName(left.Name)}"); }
            else {
                foreach (string dirPath in Directory.GetDirectories(left.Name, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(left.Name, right));

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(left.Name, "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(left.Name, right), true);
            }
        }

        public void NewFolder(string path)
        {
                if (!Directory.Exists(path) && path != null)
                {
                    Directory.CreateDirectory(path);
                }
        }

        public string previousPath(string path)
        {
            if(path.IndexOf("\\") == path.LastIndexOf("\\"))
            {
                return path.Substring(0,3);
            }
            return path.Substring(0, path.LastIndexOf("\\"));
        }
    }
}
