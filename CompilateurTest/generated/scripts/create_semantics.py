﻿
import os

filePath=os.path.dirname(os.path.realpath(__file__))
semanticDir=os.path.join(filePath, "../../semantic") 
os.makedirs(os.path.join(filePath, f"../semantic"), exist_ok = True)

for serie in [x for x in os.listdir(semanticDir) if not x.startswith(".")]:
    test_name = f"{serie}_semanticTest"
    test_file = os.path.join(filePath, f"../semantic/{test_name}.cs")

    with open(test_file, "w") as writer:
        serieDir=os.path.join(semanticDir, serie)

        writer.write("using Microsoft.VisualStudio.TestTools.UnitTesting;\n")
        writer.write("using System;\n")
        writer.write("using System.IO;\n")
        writer.write("using Compilateur.Exception;\n")
        writer.write("using CompilateurTest._Masm;\n")
        writer.write("namespace Compilateur.Tests\n")
        writer.write("{\n")
        writer.write("    [TestClass()]\n")
        writer.write(f"    public class {test_name}\n")
        writer.write("    {\n")
        writer.write("                public string RootFolder => Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), \"../../../\").ToLower());\n");
        writer.write("    //\n")
        writer.write(f"    // Serie {serie} \n")
        writer.write("    //\n")
        for inputFile in [x for x in os.listdir(serieDir) if not x.startswith(".")]:
            in_file = os.path.join(filePath, "../../semantic", serie, f"{inputFile}")
            print(in_file)
            in_file = os.path.abspath(in_file)
            print(in_file)

            out_file = os.path.join(filePath, "../output/semantic", serie)
            out_file = os.path.abspath(out_file)
            os.makedirs(out_file, exist_ok = True)
            out_file = os.path.join(out_file, f"{inputFile.replace('kiwi','asm')}")
            
            writer.write("        [TestMethod()]\n")
            name = inputFile.replace(".kiwi", "")
            writer.write(f"        public void test{serie}_{name}(){{\n")
            writer.write(f"            Program.Compile(@\"{in_file}\", \n")
            writer.write(f"                    @\"{out_file}\");\n\n")
            #             AssemblyRunner.Start(folder, "_runner", "aa.asm");
            writer.write(f"            AssemblyRunner.Start(RootFolder, \"{serie}\",  @\"{inputFile.replace('kiwi','asm')}\");\n\n")
            writer.write("        }\n\n")

        
        writer.write("    }\n")
        writer.write("}\n")
