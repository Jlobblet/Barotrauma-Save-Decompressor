using System.Collections.Generic;
using System.Linq;
using CommandLine;
using static Barotrauma_Save_Decompressor_Backend.CompressionUtil;

// ReSharper disable ClassNeverInstantiated.Global

namespace Barotrauma_Save_Decompressor_CLI;

[Verb("decompress", HelpText = "Decompress a .save file into a directory.")]
public class DecompressOptions
{
    public DecompressOptions(IEnumerable<string> decompressInputFiles, string decompressOutputDirectory)
    {
        DecompressInputFiles      = decompressInputFiles.ToList();
        DecompressOutputDirectory = decompressOutputDirectory;
    }

    [Value(0)] public List<string> DecompressInputFiles { get; }

    [Option('o', "output", Default = "")] public string DecompressOutputDirectory { get; }

    public static int Run(DecompressOptions options)
    {
        options.DecompressInputFiles.ForEach(f => DecompressToDirectory(f, options.DecompressOutputDirectory));
        return 0;
    }
}
