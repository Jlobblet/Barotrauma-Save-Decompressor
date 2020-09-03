using System;
using System.IO;
using BaroLib;

namespace Barotrauma_Save_Decompressor_Backend
{
    public static class CompressionUtil
    {
        public static void CompressDirectory(string inDir, string outDir)
        {
            Console.WriteLine($"Compressing {inDir}...");
            string outPath = Path.Combine(outDir, $"{Path.GetFileName(inDir)}.save");
            IoUtil.CompressDirectory(inDir, outPath);
            Console.WriteLine($"Compressed to {outPath}...");
            Console.WriteLine("...success");
        }

        public static void DecompressToDirectory(string inPath, string outDir)
        {
            Console.WriteLine($"Decompressing {outDir}...");
            string newDir = Path.Combine(outDir, Path.GetFileNameWithoutExtension(inPath));
            Directory.CreateDirectory(newDir);
            IoUtil.DecompressToDirectory(inPath, newDir);
            Console.WriteLine($"Decompressed to {newDir}...");
            Console.WriteLine("...success");
            
        }
    }
}
