using System;

namespace notab
{
    public abstract class CodeGenerator
    {
        public virtual bool Generate(Descriptor descriptor, GeneratorContext contentxt)
        {
            throw new NotImplementedException();
        }
    }
}