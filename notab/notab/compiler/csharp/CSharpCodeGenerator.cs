using System;
using System.Collections.Generic;

namespace notab.compiler.csharp
{
    public class CSharpCodeGenerator : CodeGenerator
    {
        public override bool Generate(ICollection<Descriptor> descriptors, GeneratorContext context)
        {
            throw new NotImplementedException();
        }

        public bool GenerateEntity(Descriptor descriptor, GeneratorContext context)
        {
            throw new NotImplementedException();
        }

        public bool GenerateManager(ICollection<Descriptor> descriptors, GeneratorContext context)
        {
            throw new NotImplementedException();
        }
    }
}