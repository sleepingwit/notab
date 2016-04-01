using System;
using System.Collections.Generic;

namespace notab
{
    public abstract class CodeGenerator
    {
        public abstract bool Generate(ICollection<Descriptor> descriptors, GeneratorContext context);
    }
}