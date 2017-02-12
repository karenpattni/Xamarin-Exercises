using MyTunes.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Windows.ApplicationModel;

namespace MyTunes
{
    class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return Package.Current.InstalledLocation.GetFileAsync(filename)
                .AsTask().Result
                .OpenStreamForReadAsync().Result;
        }
    }
}
