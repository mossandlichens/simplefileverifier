namespace SimpleFileVerifier
{
    using CommandLine;
    using CommandLine.Text;

    /// <summary>
    ///     Supported commandline options
    /// </summary>
    public class CommandLineOptions
    {
        [Option('o', "output", HelpText = "Path to SFV File")]
        public string Output { get; set; }

        [Option('d', "directory", HelpText = "Path to Directory")]
        public string Directory { get; set; }

        [Option('f', "file", HelpText = "Path to File")]
        public string File { get; set; }

        [Option('p', "pattern", HelpText = "Search pattern")]
        public string Pattern { get; set; }

        [Option('c', "check", HelpText = "Check SFV File")]
        public string Check { get; set; }

        [Option('v', "verbose", DefaultValue = true,
          HelpText = "Prints all messages to standard output.")]
        public bool Verbose { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }

    }
}
