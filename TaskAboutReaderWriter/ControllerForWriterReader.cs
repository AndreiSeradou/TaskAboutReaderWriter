using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAboutReaderWriter
{
    class ControllerForWriterReader
    {
        public string WriteOrReadPath
        {
            set;
            get;
        }

        int ReaderCount = 0;
        int WriterCount = 0;


        List<Reader> ListReader = new List<Reader>();
        List<Writer> ListWriter = new List<Writer>();
      
        public object locker = new object();
                
        public void AddReader()
        {
            Reader ReaderObject = new Reader(WriteOrReadPath);
            ListReader.Add(ReaderObject);
        }

        public void AddWriter()
        {
            Writer WriterObject = new Writer(WriteOrReadPath);
            ListWriter.Add(WriterObject);
        }

        public void DeleteReader()
        {
            ListReader.RemoveAt(0);
        }

        public void DeleteWriter()
        {
            ListWriter.RemoveAt(0);
        }

        public void WorkingWithFileReader(int IndexReader)
        {
            Monitor.Enter(ListReader);
            while (WriterCount > 0)
                Monitor.Wait(ListReader);

        }

        public void WorkingWithFileWriter()
        {
            
        }

    }
}
