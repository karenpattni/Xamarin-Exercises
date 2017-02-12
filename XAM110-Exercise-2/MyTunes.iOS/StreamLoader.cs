using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyTunes.Shared;
using System.IO;

namespace MyTunes
{
    class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return File.OpenRead(filename);
        }
    }
}