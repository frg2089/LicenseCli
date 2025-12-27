using System.Text.Json.Serialization;

using LicenseCli.Models;

namespace LicenseCli;

[JsonSourceGenerationOptions(WriteIndented = false)]
[JsonSerializable(typeof(LicensesIndex))]
[JsonSerializable(typeof(LicenseDetails))]
public sealed partial class SPDXJsonSerializerContext : JsonSerializerContext
{
}
