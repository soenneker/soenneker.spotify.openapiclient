using Soenneker.Tests.HostedUnit;

namespace Soenneker.Spotify.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SpotifyOpenApiClientTests : HostedUnitTest
{
    public SpotifyOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
