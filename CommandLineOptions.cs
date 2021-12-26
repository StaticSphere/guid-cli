using CommandLine;

public class CommandLineOptions
{
    [Option('l', "lowercase", Required = false, HelpText = "If specified, the guid is created with lowercase letters")]
    public bool LowerCase { get; set; }

    [Option('n', "nodashes", Required = false, HelpText = "If specified, the guid is created with no dashes")]
    public bool NoDashes { get; set; }
}
