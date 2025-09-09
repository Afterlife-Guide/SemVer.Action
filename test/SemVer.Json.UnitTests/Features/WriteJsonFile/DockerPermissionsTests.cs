using Microsoft.Extensions.Logging;
using SemVer.Json.Features.WriteJsonFile;
using SemVer.Json.Persistence;

namespace SemVer.Json.UnitTests.Features.WriteJsonFile;

public class DockerPermissionsTests
{
    private readonly ILogger<WriteJsonCommand> _mockLogger = Substitute.For<ILogger<WriteJsonCommand>>();
    private readonly WriteJsonCommand _sut;

    public DockerPermissionsTests()
    {
        _sut = new WriteJsonCommand(new FileWriter(), _mockLogger);
    }

    [Fact]
    public void WhenWritingToGitHubWorkspacePath_ThenNoPermissionErrorOccurs()
    {
        // arrange
        var tempDir = Path.GetTempPath();
        var testPath = Path.Combine(tempDir, "github", "workspace", "test-semver.json");
        Directory.CreateDirectory(Path.GetDirectoryName(testPath)!);
        
        var options = new WriteJsonOptions
        {
            Path = testPath,
            Major = "1",
            Minor = "2",
            Patch = "3",
            Build = "4"
        };
        
        // act & assert
        var result = _sut.Write(options);
        result.Should().Be(0);
        
        // verify file was written
        File.Exists(testPath).Should().BeTrue();
        var content = File.ReadAllText(testPath);
        content.Should().Contain("\"major\":\"1\"");
        content.Should().Contain("\"minor\":\"2\"");
        content.Should().Contain("\"patch\":\"3\"");
        content.Should().Contain("\"build\":\"4\"");
        
        // cleanup
        File.Delete(testPath);
    }
}