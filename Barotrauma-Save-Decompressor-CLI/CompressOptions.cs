using System.Collections.Generic;
using System.Linq;
using CommandLine;
using static Barotrauma_Save_Decompressor_Backend.CompressionUtil;

// ReSharper disable ClassNeverInstantiated.Global

namespace Barotrauma_Save_Decompressor_CLI;

[Verb("compress", HelpText = "Compress a directory into a .save file.")]
public class CompressOptions
{
    public CompressOptions(IEnumerable<string> compressInputFiles, string compressOutputDirectory)
    {
        CompressInputFiles      = compressInputFiles.ToList();
        CompressOutputDirectory = compressOutputDirectory;
    }

    [Value(0)] public List<string> CompressInputFiles { get; }

    [Option('o', "output", Default = "")] public string CompressOutputDirectory { get; }

    public static int Run(CompressOptions options)
    {
        options.CompressInputFiles.ForEach(f => CompressDirectory(f, options.CompressOutputDirectory));
        return 0;
    }
}
