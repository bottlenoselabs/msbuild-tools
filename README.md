# MSBuild.Tools

MSBuild extensions and settings used for all C# projects at Bottlenose Labs Inc.

## Developers: How to use

TODO:

- Add as NuGet package.
```
<PackageReference Include="bottlenoselabs.MSBuild.Tools" Version="2018.2.1" ExcludeAssets="all" PrivateAssets="All" GeneratePathProperty="true" />
<Reference Include="$(Pkgbottlenoselabs_MSBuild_Tools)\??">

- Add a `.globalconfig` file in root of repository or root directory to configure or override rules.
- Add `global_level = 101` to the file to signal that this file takes precedence.