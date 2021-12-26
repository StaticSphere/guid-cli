using CommandLine;

Parser
    .Default
    .ParseArguments<CommandLineOptions>(Environment.GetCommandLineArgs())
    .WithParsed(o =>
    {
        var guid = o switch
        {
            { LowerCase: false, NoDashes: false } => Guid.NewGuid().ToString().ToUpper(),
            { LowerCase: false, NoDashes: true } => Guid.NewGuid().ToString("N").ToUpper(),
            { LowerCase: true, NoDashes: false } => Guid.NewGuid().ToString(),
            { LowerCase: true, NoDashes: true } => Guid.NewGuid().ToString("N")
        };

        Console.WriteLine(guid);
    });
