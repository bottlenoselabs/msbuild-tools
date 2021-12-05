# MSBuild.Tools

MSBuild extensions and settings used for all C# projects at Bottlenose Labs Inc.

## Developers: How to use

1. Add the NuGet package to your `.csproj`:

```xml
<PackageReference Include="bottlenoselabs.MSBuild.Tools" Version="*.*">
    <PrivateAssets>all</PrivateAssets>
    <IncludeAssets>build</IncludeAssets>
</PackageReference>
```

2. Create a `.globalconfig` file to configure C# Rosyln analyzers:

```xml
# NOTE: Requires .NET 5 SDK (VS2019 16.8 or later)
#   but recommended to use .NET 6 SDK for better support and features such as `global_level`
#   https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#global-analyzerconfig
is_global = true
global_level = 101

# StyleCop Rules
# Description: StyleCop code analysis rules for C# projects.
dotnet_diagnostic.SA1309.severity = error
```

3. 