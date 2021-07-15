using System;
using System.IO;
using System.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace TaskAboutReaderWriter
{
    class  Writer
    {
        public Writer()
        {
          
        }
        public Writer(string Path)
        {
            WritePath = Path;
        }
        public string WritePath
        {
            set;
            get;
        }
        public async void  DocumentEditing()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(WritePath, true, System.Text.Encoding.Default))
                {
                    sw.Write("Запись: ");
                    sw.WriteLine(DateTime.Now);
                    await sw.WriteLineAsync(Console.ReadLine());
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
