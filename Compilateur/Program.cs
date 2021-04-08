using System;
using System.IO;
using Antlr4.Runtime;
using Compilateur.Exception;
using Compilateur.Generator;

namespace Compilateur
{
    public class Program
    {
        static DEMOParser parser = null;
        static void Main(string[] args)
        {
            if( args.Length >= 2)
            {
                string pathKiwi = args[0];
                string pathKAsm = args[1];
                
                Compile(pathKiwi, pathKAsm);
            }
        }

        public static void Compile(string path, string output)
        {
            var sourceCode = File.ReadAllText(path);
            // Check syntax
            var tree = Parse(sourceCode);
            
            //Et la table des symboles? 
            
            // Genrate code
            var asmCode = PrintAssemblyCode(tree);
            // Create output directory 
            CreateFolderStructur(output);
            // Print code to output file
            File.WriteAllText(output, asmCode);
        }

        private static void CreateFolderStructur(string output)
        {
            FileInfo fi = new FileInfo(output);
            Directory.CreateDirectory(fi.DirectoryName);
        }

        public static DEMOParser.DemoContext Parse(string sourceCode)
        {
            AntlrInputStream input = new AntlrInputStream(sourceCode);
            CommonTokenStream tokens = new CommonTokenStream(new DEMOLexer(input));
            parser = new DEMOParser(tokens);
            parser.RemoveErrorListeners();
            var stringErrorListener = new StringErrorListener();
            parser.AddErrorListener(stringErrorListener);

            DEMOParser.DemoContext tree;

            try
            {
                tree = parser.demo();
            }
            catch (RecognitionException e)
            {
                Console.WriteLine(e);
                throw;
            }

            if (stringErrorListener.ErrorHasBeenReported)
            {
                Console.WriteLine(stringErrorListener.ToString());
                throw new ParsingException(stringErrorListener.ToString());
            }

            return tree;
        }

        public static string PrintAssemblyCode(DEMOParser.DemoContext tree) 
        {
            var stream = new StringWriter();
            var printer = new AssemblyPrinter(stream);
            DemoVisitor visitor = new DemoVisitor(printer);
            tree.Accept(visitor);
            printer.Flush();
            printer.Close();
            return stream.ToString();
        }
    }
}
