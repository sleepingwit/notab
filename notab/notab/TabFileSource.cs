using System.IO;

namespace notab
{
    public abstract class TabFileSource
    {
        public abstract Stream Open();
    }
}