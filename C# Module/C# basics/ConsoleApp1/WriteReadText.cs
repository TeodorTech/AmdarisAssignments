using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    public class WriteReadText
    {
        public void CreateFolder()
        {
            var newFolder = Path.Combine(@"D:\LearnC#\C#basics\C-basics", "Folder");
            Directory.CreateDirectory(newFolder);
        }
   
        public void WriteTheNames(string[] cars)
        {
            File.WriteAllLines(@"D:\LearnC#\C#basics\C-basics\Folder\ListOfCars.txt", cars);
           
        }
       

        public void Info()
        {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            foreach (var info in driveInfo)
            {
                Console.WriteLine($"{info.Name},{ info.IsReady},{ info.AvailableFreeSpace}");
            }
        }
    
       
    }
}
