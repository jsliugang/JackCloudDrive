using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\workspace\2018-05\JackCloudDrive\test\Test_FileWatcher\file";

            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = path;
            fsw.IncludeSubdirectories = true;   //设置监控C盘目录下的所有子目录
            fsw.Filter = "*.*";   //设置监控文件的类型
            fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size;   //设置文件的文件名、目录名及文件的大小改动会触发Changed事件
            fsw.Created += new FileSystemEventHandler(fileSystemWatcher_EventHandle);  //绑定事件触发后处理数据的方法。
            fsw.Deleted += new FileSystemEventHandler(fileSystemWatcher_EventHandle);
            fsw.Changed += new FileSystemEventHandler(fileSystemWatcher_EventHandle);
            fsw.Renamed += new RenamedEventHandler(fileSystemWatcher_Renamed);  //重命名事件与增删改传递的参数不一样。

            fsw.EnableRaisingEvents = true;  //启动监控

            Console.ReadLine();
        }

        private static void fileSystemWatcher_EventHandle(object sender, FileSystemEventArgs e)  //文件增删改时被调用的处理方法
        {
            Console.WriteLine($"file {e.Name} : {e.ChangeType.ToString().ToLower()} at {e.FullPath}");
        }

        private static void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)   //文件重命名时被调用的处理方法
        {
            Console.WriteLine($"file {e.OldName} : rename to {e.Name} at {e.FullPath}");
        }
    }
}
