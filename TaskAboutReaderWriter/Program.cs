using System;
using System.IO;

namespace TaskAboutReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer wr = new Writer(@"C:\Users\Lenovo\Desktop\task.txt");
            wr.DocumentEditing();
        }
    }
}
