using System;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

namespace EnvironmentAssessment
{
    class CAssemblyManager
    {
        public static void LoadAssemblies()
        {
            ExtractResources();
            ResolveAssemblies();
        }

        private static void ResolveAssemblies()
        {
            string includes = Core.IncludesPath;
            var imported_dlls = new DirectoryInfo(includes).GetFiles("*.dll");
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                foreach (var fi in imported_dlls)
                {
                    if (fi.Name == args.Name.Split(',')[0] + ".dll")
                    {
                        return Assembly.LoadFile(fi.FullName);
                    }
                }
                return null;
            };

        }

        public static void ExtractResources()
        {
            Assembly _Assembly = Assembly.GetExecutingAssembly();
            Stream _ResourceStream = _Assembly.GetManifestResourceStream(Core.ProductName + ".Includes.resources");
            Stream _MemoryStream = new MemoryStream();
            Common.Lzma.CDecoder LZMADecoder = new Common.Lzma.CDecoder();
            LZMADecoder._DecodeStream(_ResourceStream, _MemoryStream);
            _MemoryStream.Seek(0, SeekOrigin.Begin);
            if (!System.IO.Directory.Exists(Core.IncludesPath)) { System.IO.Directory.CreateDirectory(Core.IncludesPath); }
            //Common.Lzma.CTarHelper.UntarTo(_MemoryStream, Core.IncludesPath);

            foreach (var entryStream in Common.Lzma.CTarHelper.Untar(_MemoryStream))
            {
                var outputFile = "";
                if (entryStream.FileName.Contains("EnvironmentAssessment.Web.exe") || entryStream.FileName.Contains("index.html"))
                {
                    outputFile = Path.Combine(Core.TempPath, entryStream.FileName);
                } else
                {
                    outputFile = Path.Combine(Core.IncludesPath, entryStream.FileName);
                }
                var outputDir = Path.GetDirectoryName(outputFile);
                Directory.CreateDirectory(outputDir);
                using (var outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                {
                    entryStream.CopyTo(outputStream);
                }
                File.SetLastWriteTime(outputFile, entryStream.LastModifiedTime);
            }

            _MemoryStream.Dispose();
            _ResourceStream.Dispose();
        }
    }
}
