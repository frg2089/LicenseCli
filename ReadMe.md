# License Cli

A command-line tool for generating license files, supporting multiple open-source license formats.

## Features

- 🚀 Quickly generate standard license files
- 📝 Support for custom author and copyright information
- 🔍 Support for searching and finding licenses
- 📦 Automatic license caching

## Installation

```bash
dotnet tool install --global LicenseCli
```

## Usage

### Creating License Files

```bash
# Create MIT license
dotnet license new MIT

# Create license with author information
dotnet license new MIT "Your Name"

# Specify output path
dotnet license new MIT -o /path/to/LICENSE

# Quiet mode (no console output)
dotnet license new MIT -q
```

### Searching Licenses

```bash
# Search for licenses
dotnet license search gpl
```

## Contributing

Issues and Pull Requests are welcome to help improve this project.

## License

This project is open-sourced under the MIT License.
