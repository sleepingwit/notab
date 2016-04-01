using System;
using System.IO;

namespace notab
{
    public class Importer
    {
        public Descriptor Import(TabFileSource source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            using (StreamReader streamReader = new StreamReader(source.Open()))
            {
            }
            throw new NotImplementedException();
        }

    }
}