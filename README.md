# StaticSphere.Cli.Guid

This project is a simple .NET 6 CLI tool that can be installed as a global dotnet tool, and will generate guids from the command line. As a .NET 6 CLI, it can be installed on Windows, Mac, and Linux.

## Install

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
