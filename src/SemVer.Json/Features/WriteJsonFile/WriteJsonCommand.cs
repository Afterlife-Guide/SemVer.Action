using System.Text.Json;
using Microsoft.Extensions.Logging;
using SemVer.Json.Persistence;

namespace SemVer.Json.Features.WriteJsonFile;

public class WriteJsonCommand(IFileWriter fileWriter, ILogger<WriteJsonCommand> logger)
{
    private readonly JsonSerializerOptions _jsonSerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public int Write(WriteJsonOptions options)
    {
        var semVer = new SemVer
        {
            Major = options.Major,
            Minor = options.Minor,
            Patch = options.Patch,
            Build = options.Build
        };
        var json = JsonSerializer.Serialize(semVer, _jsonSerializerOptions);
        
        logger.LogInformation("Writing version {Major}.{Minor}.{Patch}.{Build} as JSON: {Json}", options.Major, options.Minor, options.Patch, options.Build, json);
        logger.LogInformation("Writing to file: {Path}", options.Path);
        
        fileWriter.WriteJson(json, options.Path);

        return 0;
    }
}