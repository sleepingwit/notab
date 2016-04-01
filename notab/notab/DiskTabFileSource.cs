using System;
using System.IO;

namespace notab
{
    public class DiskTabFileSource : TabFileSource
    {
        public DiskTabFileSource(string filename)
        {
            Filename = filename;
        }

        public string Filename { get; }

        public override Stream Open()
        {
            if (String.IsNullOrEmpty(Filename))
                throw new ArgumentException("Invalid filename", nameof(Filename));

            string fullpath = Path.GetFullPath(Filename);
            if (!File.Exists(fullpath))
                throw new FileNotFoundException("TabFile didn't exist", Filename);

            return File.OpenRead(fullpath);
        }
    }
}