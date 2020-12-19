# my-msbuild

My preferred settings and extensions for MSBuild.

## Developers: How to use

### Option 1: Clone directory and copy files

### Option 2: Add as Git submodule (preferred)

### ~~Option 3: Add as NuGet package~~

Not possible because of how MSBuild deals with the `BaseIntermediateOutputPath` property. `.props` and `.targets` can be added to your project though NuGet packages but they are imported as projects *after* the SDK `.props` and `.targets` are imported as projects.
