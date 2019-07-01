# Discord.Net

An unofficial .NET API Wrapper for the Discord client (https://discordapp.com).

This branch is an unstable reference design of the next major release, Discord.Net v3. Currently, this branch
does not offer any functionality, and is only being used for API design.

## Contributing

This branch is being developed on preview releases of .NET Core and Visual Studio; the following features
are necessary to contribute:
- C# 8 with Nullable Reference Types and IAsyncEnumerable
- .NET Core 3 with ValueTask support

The following configurations are known to work:
- Visual Studio 2019 16.2 Preview 3
- .NET Core SDK 3.0.100-preview6-012264

### Documentation

Documentation Strings are currently being left out, primarily because I find them extremely distracting when
trying to read over long interfaces, but also because this design will likely be iterated on before being finalized,
and it would be annoying to have to move docstrings around.

Please leave docstrings out of contributions until the implementation round is finished.

Usability documentation is being provided in sample solutions.
