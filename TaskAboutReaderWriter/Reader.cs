using System;
using System.IO;

namespace TaskAboutReaderWriter
{
    class Reader
    {
        public Reader()
        {
          
        }
        public Reader(string Path)
        {
            ReadPath = Path;
        }
        public string ReadPath
        {
            set;
            get;
        }
        public async void ReadingDocuments()
        {
            using (StreamReader sr = new StreamReader(ReadPath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
