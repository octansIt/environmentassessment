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
            Common.LZMA.CDecoder LZMADecoder = new Common.LZMA.CDecoder();
            LZMADecoder._DecodeStream(_ResourceStream, _MemoryStream);
            _MemoryStream.Seek(0, SeekOrigin.Begin);
            if (!System.IO.Directory.Exists(Core.IncludesPath)) { System.IO.Directory.CreateDirectory(Core.IncludesPath); }
            Common.LZMA.CTarHelper.UntarTo(_MemoryStream, Core.IncludesPath);
            _MemoryStream.Dispose();
            _ResourceStream.Dispose();
        }
    }
}
