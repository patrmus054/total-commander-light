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

        public void Delete(DirectoryElement name)
        {
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
        public void Copy(DirectoryElement left, string right)
        {
            if (left == null)
            {
                form_copy_item form = new form_copy_item();
                form.StartPosition = FormStartPosition.CenterParent;
                form.Directories = LoadPathfolders("D:\\");
                form.ShowDialog();
                FrameCopyPresenter frameCopyPresenter;
                if (FrameCopyPresenter.selectedItem.Type == DirectoryElementType.FILE) { File.Copy(FrameCopyPresenter.selectedItem.Name, right); }
                else
                {
                    foreach (string dirPath in Directory.GetDirectories(FrameCopyPresenter.selectedItem.Name, "*", SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(FrameCopyPresenter.selectedItem.Name, right));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(FrameCopyPresenter.selectedItem.Name, "*.*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(FrameCopyPresenter.selectedItem.Name, right), true);
                }

            }
            else
            {
                
                if (left.Type == DirectoryElementType.FILE) { File.Copy(left.Name, right); }
                else {
                    foreach (string dirPath in Directory.GetDirectories(left.Name, "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(left.Name, right));

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(left.Name, "*.*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(left.Name, right), true);
                }
                
                //int index = left.Name.LastIndexOf("\\");
                //string leftName = left.Name.Substring(index);
                //try
                //{
                //    if (left.Type == DirectoryElementType.FILE)
                //    {
                //        File.Copy(left.Name, right.Name + leftName);
                //    }
                //    else
                //    {
                //        if (right.Type == DirectoryElementType.DIRECTORY)
                //        {
                //            Directory.Move(left.Name, right.Name);
                //        }
                //    }
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e);
                //}
            }
        }
        public void Move(DirectoryElement left, DirectoryElement right)
        {
            if (left == null || right == null)
            {
                form_move_item form = new form_move_item();
                form.Directories = LoadPathfolders("D:\\");
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
            else
            {
                int index = left.Name.LastIndexOf("\\");
                string leftName = left.Name.Substring(index);
                try
                {
                    if (left.Type == DirectoryElementType.FILE)
                    {
                        File.Move(left.Name, right.Name+leftName);
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
        }
        public void NewFolder(DirectoryElement left, string path)
        {
            form_new_folder form = new form_new_folder();
            if(path == "")
            {
                form.Directories = LoadPathfolders("D:\\");
            }
            else
            {
                form.Directories = LoadPathfolders(path);
            }
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            if (form.GetNewFolderName != null && form.GetNewFolderDestination != null)
            {
                if (Directory.Exists(form.GetNewFolderDestination))
                {
                    Directory.CreateDirectory($"{form.GetNewFolderDestination}\\{form.GetNewFolderName}");
                }
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
