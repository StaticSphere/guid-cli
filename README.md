# StaticSphere.Cli.Guid

This project is a simple .NET 6 CLI tool that can be installed as a global dotnet tool, and will generate GUID's from the command line. As a .NET 6 CLI, it can be installed on Windows, Mac, and Linux.

## Installation

To install the tool, you can use the following command to install it from Nuget.org:

```
dotnet tool install --global StaticSphere.Cli.Guid
```

Or if you wish to compile it locally and install it, you can do so with the following commands:

```
cd <<path to source>>
dotnet pack
dotnet tool install --global --add-source ./dist StaticSphere.Cli.Guid
```

## Usage

Once installed, you can execute the CLI to create a guid with the `guid` command:

```
guid
```

By default, the produced GUID is in all caps, and includes dashes. You can use the `--lowercase` or `-l` parameter to signal that you want the GUID to have lowercased letters. You can also specify `--nodashes` or `-n` to remove the dashes. You can also use `-lf` to generate a guid with lowercased and with no dashes.

## Dependencies

This project depends on the [CommandLineParser](https://github.com/commandlineparser/commandline) Nuget package to handle parsing of command line parameters.
