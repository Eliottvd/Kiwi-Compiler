using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace CompilateurTest._Masm
{
    public static class AssemblyRunner
    {
        /// <summary>
        /// Compile, link and run the assembly code generated
        /// The result is placed into an output file 
        /// </summary>
        /// <param name="mountFolder">The full path of the mount target folder</param>
        /// <param name="serie">Le nom du répertoire "série"</param>
        /// <param name="asmFile">__asm_code_File__.asm</param>
        /// <returns>The output file name</returns>
        public static string Start(string mountFolder, string serie, string asmFile)
        {

            var dosBoxPath = Path.Combine(mountFolder, @"_Masm\DosBox\DosBox.exe");
            var masmPath = Path.Combine("c:", @"_Masm\MP\masm.exe");
            masmPath = To8_3(masmPath);

            var linkPath = Path.Combine("c:", @"_Masm\MP\link.exe");
            linkPath = To8_3(linkPath);
            
            string generatedPath = Path.Combine(@"c:\generated\output\semantic\", serie);
            generatedPath = To8_3(generatedPath);

            FileInfo fi = new FileInfo(asmFile);
            asmFile = Path.Combine(generatedPath, asmFile);
            var objFile = Path.Combine(fi.Name.Replace(".asm",".obj"));
            var outputFile = Path.Combine(generatedPath, fi.Name.Replace(".asm",".txt"));
            var exeFile = Path.Combine(generatedPath, fi.Name.Replace(".asm",".exe"));
            asmFile = To8_3(asmFile);
            objFile = To8_3(objFile);
            outputFile = To8_3(outputFile);
            exeFile = To8_3(exeFile);

            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = dosBoxPath,
                WorkingDirectory = mountFolder,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            // Prepare dosbox argument
            //-c mount c ./mp -c c: -c masm aa.asm,,,,, -c link aa.obj,,,,, -c -c aa.exe >> aa.out -c exit
            // Mount disk
            psi.Arguments = " -c \"mount c '" + mountFolder + "'\"";
            // Change disk
            psi.Arguments += "-c c: -c \"cd "+generatedPath+"\"";
            // Compile assembly
            psi.Arguments += "-c \"" + masmPath + " " + asmFile + ",,,,,,\" ";
            // Link obj file
            psi.Arguments += "-c \"" + linkPath + " " + objFile + ",,,,,\" ";
            // Remove tmp files
            psi.Arguments += "-c \"del *.crf\" -c \"del *.lst\" -c \"del *.obj\" -c \"del *.map\"";
            // Run executable and redirect to file
            psi.Arguments += "-c \"" + exeFile + " >> " + outputFile + "\"";
            // Exit from DosBox
            psi.Arguments += "-c \"exit\" ";

            Process p = new Process();
            p.StartInfo = psi;
            p.OutputDataReceived += (sender, args) => Console.Out.WriteLine(args.Data);
            p.ErrorDataReceived += (sender, args) => Console.Out.WriteLine(args.Data);
            p.Start();
            p.BeginErrorReadLine();
            p.BeginOutputReadLine();
            p.WaitForExit();

            return Path.Combine(mountFolder, outputFile);
        }

        public static string To8_3(string path)
        {
            String str = string.Empty;
            var tree = path.Split("\\");
            foreach (var leaf in tree)
            {
                var item = leaf;
                if (leaf.Contains("."))
                {
                    var index = leaf.LastIndexOf(".");
                    var name = leaf.Substring(0, index );
                    item = name;
                    var exten = leaf.Substring(index, leaf.Length - index );
                    if( name.Length>8)
                        item = name.Substring(0, 6) + "~1";
                    str += item + exten;
                }
                else
                {
                    if (leaf.Length > 8)
                        item = leaf.Substring(0, 6) + "~1";
                    str += item + "\\";
                }
            }
            return str.TrimEnd('\\');
        }
    }
}
