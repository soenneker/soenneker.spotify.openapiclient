[![](https://img.shields.io/nuget/v/soenneker.spotify.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.spotify.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.spotify.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.spotify.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.spotify.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.spotify.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.spotify.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.spotify.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Spotify.OpenApiClient

Generated Spotify Web API client for artists, albums, tracks, playlists, shows, episodes, audiobooks, search, recommendations, playback, and the current user's library.

## Installation

```bash
dotnet add package Soenneker.Spotify.OpenApiClient
```

For application registration and configuration-based authentication, use `Soenneker.Spotify.OpenApiClientUtil`. Instantiate this package directly when you need to supply your own Kiota request adapter.

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Spotify.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.spotify.com/v1/")
};
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", accessToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = httpClient.BaseAddress.ToString().TrimEnd('/')
};

var spotify = new SpotifyOpenApiClient(adapter);
var profile = await spotify.Me.GetAsync(
    cancellationToken: cancellationToken);
```

Endpoints under `Me` require a user access token and the relevant OAuth scopes. Public catalog endpoints can use an application token where Spotify permits it; playback and library mutations require user authorization.
