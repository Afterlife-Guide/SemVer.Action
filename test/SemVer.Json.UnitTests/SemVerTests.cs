namespace SemVer.Json.UnitTests;

public class SemVerTests
{
    [Property]
    public Property ToVersion_ReturnsAConcatenatedVersionString(string major, string minor, string patch, string build)
    {
        var semVer = new SemVer
        {
            Major = major,
            Minor = minor,
            Patch = patch,
            Build = build
        };

        var result = semVer.ToVersion();

        return (result == $"{major}.{minor}.{patch}.{build}").ToProperty();
    }
}