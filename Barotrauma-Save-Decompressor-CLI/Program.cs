using CommandLine;

namespace Barotrauma_Save_Decompressor_CLI;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    private static void Main(string[] args)
    {
        Parser.Default.ParseArguments<CompressOptions, DecompressOptions>(args)
              .MapResult((CompressOptions   o) => CompressOptions.Run(o),
                         (DecompressOptions o) => DecompressOptions.Run(o),
                         err => 1);
    }
}
