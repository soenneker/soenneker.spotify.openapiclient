using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Spotify.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SpotifyOpenApiClientTests : FixturedUnitTest
{
    public SpotifyOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
