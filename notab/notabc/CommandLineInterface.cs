using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace notab
{
    public class CommandLineInterface
    {
        public CommandLineInterface()
        {
            Generators = new Dictionary<string, CodeGenerator>();
        }

        public Dictionary<string, CodeGenerator> Generators { get; }

        public void RegisterGenerator(string name, CodeGenerator generator)
        {
            Generators.Add(name, generator);
        }

        public int Run(string[] args)
        {
            Collection<Descriptor> descriptors = ImportAll(ParseFilenames(args));
            GeneratorContext context = ParserContext(args);
            GenerateAll(descriptors, context);

            return 0;
        }

        private Collection<Descriptor> ImportAll(ICollection<string> filenames)
        {
            Importer importer = new Importer();
            Collection<Descriptor> descriptors = new Collection<Descriptor>();
            foreach (string filename in filenames)
            {
                DiskTabFileSource source = new DiskTabFileSource(filename);
                descriptors.Add(importer.Import(source));
            }
            return descriptors;
        }

        private void GenerateAll(ICollection<Descriptor> descriptors, GeneratorContext context)
        {
            foreach (KeyValuePair<string, CodeGenerator> generator in Generators)
            {
                generator.Value.Generate(descriptors, context);
            }
        }

        private Collection<string> ParseFilenames(string[] args)
        {
            return new Collection<string>();
        }

        private GeneratorContext ParserContext(string[] args)
        {
            return new GeneratorContext();
        }
    }
}