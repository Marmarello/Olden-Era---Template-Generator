namespace Olden_Era___Template_Editor.Services;

internal static class UpdatePolicy
{
    internal static bool TryParseReleaseVersion(string tagName, out Version? version)
        => Version.TryParse(tagName.TrimStart('v'), out version);

    internal static string BuildUpdateAvailableMessage(Version latestVersion, Version? currentVersion)
        => $"A new version is available: {FormatVersion(latestVersion)}\n" +
           $"You are running: {FormatVersion(currentVersion ?? new Version(0, 0))}\n\n" +
           "The GitHub releases page will be opened so you can review and install the update manually.\n\nOpen releases page now?";

    private static string FormatVersion(Version version)
        => version.Build > 0 ? $"v{version.Major}.{version.Minor}.{version.Build}" : $"v{version.Major}.{version.Minor}";
}
