# YouTubeSharp

A comprehensive C# library for interacting with the YouTube Data API v3. YouTubeSharp provides a clean, type-safe wrapper around YouTube's REST API endpoints, making it easy to integrate YouTube functionality into your .NET applications.

## 📋 Table of Contents

- [Features](#features)
- [Architecture](#architecture)
- [Installation](#installation)
- [Quick Start](#quick-start)
- [Configuration](#configuration)
- [API Reference](#api-reference)
  - [Videos](#videos)
  - [Channels](#channels)
  - [Playlists](#playlists)
  - [Playlist Items](#playlist-items)
  - [Comments](#comments)
  - [Comment Threads](#comment-threads)
  - [Subscriptions](#subscriptions)
  - [Captions](#captions)
  - [Activities](#activities)
  - [Search](#search)
  - [Channel Sections](#channel-sections)
  - [Channel Banners](#channel-banners)
  - [Thumbnails](#thumbnails)
  - [Video Categories](#video-categories)
  - [Video Abuse Report Reasons](#video-abuse-report-reasons)
  - [Watermarks](#watermarks)
  - [Playlist Images](#playlist-images)
  - [Members](#members)
  - [Memberships Levels](#memberships-levels)
  - [i18n Languages](#i18n-languages)
  - [i18n Regions](#i18n-regions)
- [Authentication](#authentication)
- [Examples](#examples)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## ✨ Features

- **Complete API Coverage**: Access all YouTube Data API v3 endpoints through a unified client
- **OAuth 2.0 Support**: Built-in OAuth 2.0 authentication with automatic token refresh
- **Type-Safe Responses**: Strongly-typed request and response models
- **Clean Architecture**: Separation of concerns with Domain, Infrastructure, and Application layers
- **Async-Ready**: Built on RestSharp for efficient HTTP communication
- **Newtonsoft.Json Integration**: Seamless JSON serialization/deserialization

## 🏗️ Architecture

YouTubeSharp follows Clean Architecture principles with clear separation of concerns:

### Project Structure

```
YouTubeSharp/
├── YouTubeSharp.Domain/                 # Domain layer - Business logic & contracts
│   ├── Activities/
│   ├── Captions/
│   ├── Channels/
│   ├── Comments/
│   ├── I18nLanguages/
│   ├── I18nRegions/
│   ├── Members/
│   ├── MembershipsLevels/
│   ├── PlaylistImages/
│   ├── PlaylistItems/
│   ├── Playlists/
│   ├── Subscriptions/
│   ├── Thumbnails/
│   ├── Videos/
│   ├── Watermarks/
│   └── ... (additional resources)
│
├── YouTubeSharp.Infrastructure/         # Infrastructure layer - API implementations
│   ├── Activities/
│   ├── Captions/
│   ├── Channels/
│   ├── Comments/
│   ├── AuthorizationInterceptor.cs
│   └── ... (implementation classes)
│
├── YouTubeSharp/                        # Client layer - Public facade
│   ├── YouTubeClient.cs
│   ├── IYouTubeClient.cs
│   └── credentials.json
│
└── YouTubeSharp.Application/            # Application layer - Usage examples
	└── Program.cs
```

### Layer Responsibilities

- **Domain (YouTubeSharp.Domain)**: Defines interfaces and data models for all YouTube resources
- **Infrastructure (YouTubeSharp.Infrastructure)**: Implements domain interfaces with actual HTTP calls to YouTube API
- **Client (YouTubeSharp)**: Provides composition root and unified access to all resources via `YouTubeClient`
- **Application (YouTubeSharp.Application)**: Demonstrates library usage with console application examples

## 📦 Installation

### NuGet Package

```bash
dotnet add package YouTubeSharp
```

### From Source

1. Clone the repository:
```bash
git clone https://github.com/ydahan56/YouTubeSharp.git
```

2. Build the solution:
```bash
dotnet build YouTubeSharp.slnx
```

## 🚀 Quick Start

### Basic Usage

```csharp
using YouTubeSharp;

// Initialize with your credentials file
var youtubeClient = new YouTubeClient("credentials.json");

// Access any resource through the client
var videosResponse = youtubeClient.Videos.List(new VideosListRequest 
{
	Part = "snippet,statistics",
	MaxResults = 10,
	Chart = "mostPopular"
});

if (videosResponse.IsSuccessful)
{
	foreach (var video in videosResponse.Data.Items)
	{
		Console.WriteLine($"Title: {video.Snippet.Title}");
		Console.WriteLine($"Views: {video.Statistics.ViewCount}");
	}
}
```

## 🔐 Configuration

### Setting Up OAuth 2.0 Credentials

1. Go to [Google Cloud Console](https://console.cloud.google.com/)
2. Create a new project
3. Enable the YouTube Data API v3
4. Create OAuth 2.0 credentials (Desktop application)
5. Download the credentials JSON file
6. Place it in your project as `credentials.json`

### Credentials File Format

```json
{
  "installed": {
	"client_id": "YOUR_CLIENT_ID.apps.googleusercontent.com",
	"client_secret": "YOUR_CLIENT_SECRET",
	"auth_uri": "https://accounts.google.com/o/oauth2/auth",
	"token_uri": "https://oauth2.googleapis.com/token",
	"redirect_uris": ["http://localhost"]
  }
}
```

## 📚 API Reference

All endpoints follow the YouTube Data API v3 specification. Each resource can be accessed through the main `YouTubeClient` instance.

### Videos

Access and manage YouTube videos.

**Methods:**
- `List(VideosListRequest)` - Retrieve video information
  ```csharp
  var response = youtubeClient.Videos.List(new VideosListRequest 
  {
	  Part = "snippet,statistics,contentDetails",
	  Id = "video_id"
  });
  ```

- `Insert(VideosInsertRequest)` - Upload a new video
  ```csharp
  var response = youtubeClient.Videos.Insert(new VideosInsertRequest
  {
	  Part = "snippet,status",
	  VideoFile = File.ReadAllBytes("video.mp4")
  });
  ```

- `Update(VideosUpdateRequest)` - Update video metadata
  ```csharp
  var response = youtubeClient.Videos.Update(new VideosUpdateRequest
  {
	  Part = "snippet",
	  VideoId = "video_id",
	  Title = "New Title"
  });
  ```

- `Delete(VideosDeleteRequest)` - Delete a video
  ```csharp
  var response = youtubeClient.Videos.Delete(new VideosDeleteRequest
  {
	  Id = "video_id"
  });
  ```

### Channels

Retrieve and update YouTube channel information.

**Methods:**
- `list(ChannelsListRequest)` - Get channel information
  ```csharp
  var response = youtubeClient.Channels.list(new ChannelsListRequest
  {
	  Part = "snippet,statistics,brandingSettings",
	  Id = "channel_id"
  });
  ```

- `update(ChannelsUpdateRequest, ChannelItem)` - Update channel metadata
  ```csharp
  var response = youtubeClient.Channels.update(
	  new ChannelsUpdateRequest { Part = "brandingSettings" },
	  channelItem
  );
  ```

### Playlists

Manage YouTube playlists.

**Methods:**
- `list(PlaylistsListRequest)` - Retrieve playlists
  ```csharp
  var response = youtubeClient.Playlists.list(new PlaylistsListRequest
  {
	  Part = "snippet,contentDetails",
	  ChannelId = "channel_id"
  });
  ```

- `insert(PlaylistsInsertRequest, PlaylistItem)` - Create a new playlist
  ```csharp
  var response = youtubeClient.Playlists.insert(
	  new PlaylistsInsertRequest { Part = "snippet,status" },
	  playlistItem
  );
  ```

- `update(PlaylistsUpdateRequest, PlaylistItem)` - Update playlist information
  ```csharp
  var response = youtubeClient.Playlists.update(
	  new PlaylistsUpdateRequest { Part = "snippet" },
	  playlistItem
  );
  ```

- `delete(PlaylistsDeleteRequest)` - Delete a playlist
  ```csharp
  var response = youtubeClient.Playlists.delete(new PlaylistsDeleteRequest
  {
	  Id = "playlist_id"
  });
  ```

### Playlist Items

Manage items within playlists.

**Methods:**
- `list(string, ...)` - Retrieve playlist items
  ```csharp
  var response = youtubeClient.PlaylistItems.list(
	  part: "snippet,status",
	  playlistId: "playlist_id"
  );
  ```

- `insert(string, PlaylistItem, ...)` - Add item to playlist
  ```csharp
  var response = youtubeClient.PlaylistItems.insert(
	  "snippet,status",
	  playlistItem
  );
  ```

- `update(string, PlaylistItem, ...)` - Update playlist item
  ```csharp
  var response = youtubeClient.PlaylistItems.update(
	  "snippet",
	  playlistItem
  );
  ```

- `delete(string, ...)` - Remove item from playlist
  ```csharp
  var response = youtubeClient.PlaylistItems.delete("playlist_item_id");
  ```

### Comments

Access and manage comments on YouTube.

**Methods:**
- `list(CommentsListRequest)` - Get comments
  ```csharp
  var response = youtubeClient.Comments.list(new CommentsListRequest
  {
	  Part = "snippet",
	  Id = "comment_id"
  });
  ```

- `insert(CommentsInsertRequest, CommentItem)` - Add a comment
  ```csharp
  var response = youtubeClient.Comments.insert(
	  new CommentsInsertRequest { Part = "snippet" },
	  commentItem
  );
  ```

- `update(CommentsUpdateRequest, CommentItem)` - Modify a comment
  ```csharp
  var response = youtubeClient.Comments.update(
	  new CommentsUpdateRequest { Part = "snippet" },
	  commentItem
  );
  ```

- `delete(CommentsDeleteRequest)` - Remove a comment
  ```csharp
  var response = youtubeClient.Comments.delete(new CommentsDeleteRequest
  {
	  Id = "comment_id"
  });
  ```

- `setModerationStatus(CommentsSetModerationStatusRequest)` - Set comment moderation status
  ```csharp
  var response = youtubeClient.Comments.setModerationStatus(
	  new CommentsSetModerationStatusRequest
	  {
		  Id = "comment_id",
		  ModerationStatus = "published"
	  }
  );
  ```

### Comment Threads

Manage comment threads on videos.

**Methods:**
- `list(CommentThreadsListRequest)` - Retrieve comment threads
- `insert(CommentThreadsInsertRequest, CommentThread)` - Create a comment thread
- `update(CommentThreadsUpdateRequest, CommentThread)` - Update a comment thread
- `delete(CommentThreadsDeleteRequest)` - Delete a comment thread
- `setModerationStatus(CommentThreadsSetModerationStatusRequest)` - Update moderation status

### Subscriptions

Manage YouTube channel subscriptions.

**Methods:**
- `list(SubscriptionsListRequest)` - List subscriptions
  ```csharp
  var response = youtubeClient.Subscriptions.list(new SubscriptionsListRequest
  {
	  Part = "snippet,contentDetails",
	  Mine = true
  });
  ```

- `insert(SubscriptionsInsertRequest, SubscriptionItem)` - Subscribe to a channel
- `delete(SubscriptionsDeleteRequest)` - Unsubscribe from a channel

### Captions

Manage video captions and subtitles.

**Methods:**
- `list(CaptionsListRequest)` - List video captions
- `insert(CaptionsInsertRequest, Caption)` - Add captions to video
- `update(CaptionsUpdateRequest, Caption)` - Update caption content
- `download(CaptionsDownloadRequest)` - Download caption file
- `delete(CaptionsDeleteRequest)` - Remove captions

### Activities

Retrieve channel activity feeds.

**Methods:**
- `list(string, string?, bool?, ...)` - Get channel activities
  ```csharp
  var response = youtubeClient.Activities.list(
	  "snippet,contentDetails",
	  channelId: "channel_id"
  );
  ```

### Search

Search for videos, channels, and playlists.

**Methods:**
- `list(string, ...)` - Search YouTube
  ```csharp
  var response = youtubeClient.Search.list(
	  "snippet",
	  q: "search query",
	  maxResults: 25
  );
  ```

- `insert(string, SearchResource)` - Create a search query
- `update(string, SearchResource)` - Update search query
- `delete(string)` - Delete search query

### Channel Sections

Manage channel section organization.

**Methods:**
- `list(ChannelSectionsListRequest)` - List channel sections
- `insert(ChannelSectionsInsertRequest, ChannelSection)` - Create channel section
- `update(ChannelSectionsUpdateRequest, ChannelSection)` - Update channel section
- `delete(ChannelSectionsDeleteRequest)` - Delete channel section

### Channel Banners

Manage channel banner images.

**Methods:**
- `insert(ChannelBannersInsertRequest, byte[])` - Upload banner image

### Thumbnails

Manage video thumbnails.

**Methods:**
- `set(ThumbnailsSetRequest, byte[], string, string)` - Upload custom thumbnail

### Video Categories

Access YouTube video categories.

**Methods:**
- `list(VideoCategoriesListRequest)` - List video categories

### Video Abuse Report Reasons

Get abuse report reasons for videos.

**Methods:**
- `list(VideoAbuseReportReasonsListRequest)` - List abuse report reasons

### Watermarks

Manage channel watermarks.

**Methods:**
- `set(WatermarksSetRequest, byte[], string, string)` - Set channel watermark
- `unset(WatermarksUnsetRequest)` - Remove channel watermark

### Playlist Images

Manage playlist cover images.

**Methods:**
- `list(PlaylistImagesListRequest)` - List playlist images
- `insert(PlaylistImagesInsertRequest, byte[], string)` - Upload playlist image
- `delete(PlaylistImagesDeleteRequest)` - Delete playlist image

### Members

Access YouTube Members (requires channel membership).

**Methods:**
- `list(MembersListRequest)` - List channel members

### Memberships Levels

Manage YouTube memberships levels.

**Methods:**
- `list(MembershipsLevelsListRequest)` - List membership levels

### i18n Languages

Get available languages for internationalization.

**Methods:**
- `list(I18nLanguagesListRequest)` - List available languages

### i18n Regions

Get available regions for internationalization.

**Methods:**
- `list(I18nRegionsListRequest)` - List available regions

## 🔑 Authentication

YouTubeSharp handles OAuth 2.0 authentication automatically:

1. On first run, a browser window opens for user login
2. Access token is obtained and stored locally
3. Token is automatically refreshed when expired
4. Credentials stored in `YouTube.Auth.Store` folder

```csharp
var youtubeClient = new YouTubeClient("credentials.json");
// Browser opens for authentication if not previously authenticated
// Subsequent calls use cached/refreshed credentials
```

## 📖 Examples

### Example 1: Get Video Statistics

```csharp
using YouTubeSharp;

var client = new YouTubeClient("credentials.json");

var response = client.Videos.List(new VideosListRequest
{
	Part = "snippet,statistics",
	Id = "dQw4w9WgXcQ" // Rick Astley - Never Gonna Give You Up
});

if (response.IsSuccessful)
{
	var video = response.Data.Items[0];
	Console.WriteLine($"Title: {video.Snippet.Title}");
	Console.WriteLine($"Views: {video.Statistics.ViewCount}");
	Console.WriteLine($"Likes: {video.Statistics.LikeCount}");
	Console.WriteLine($"Comments: {video.Statistics.CommentCount}");
}
```

### Example 2: List Channel Subscriptions

```csharp
var response = client.Subscriptions.list(new SubscriptionsListRequest
{
	Part = "snippet,contentDetails",
	Mine = true,
	MaxResults = 50
});

if (response.IsSuccessful)
{
	foreach (var subscription in response.Data.Items)
	{
		Console.WriteLine($"Subscribed to: {subscription.Snippet.Title}");
		Console.WriteLine($"Channel ID: {subscription.Snippet.ResourceId.ChannelId}");
	}
}
```

### Example 3: Search for Videos

```csharp
var response = client.Search.list(
	"snippet",
	q: "C# programming",
	maxResults: 10,
	type: "video"
);

if (response.IsSuccessful)
{
	foreach (var item in response.Data.Items)
	{
		Console.WriteLine($"Title: {item.Snippet.Title}");
		Console.WriteLine($"URL: https://www.youtube.com/watch?v={item.Id.VideoId}");
	}
}
```

### Example 4: Create a Playlist

```csharp
var playlist = new PlaylistItem
{
	Snippet = new PlaylistSnippet
	{
		Title = "My Awesome Playlist",
		Description = "A collection of great videos",
		ChannelId = "UC..." // Your channel ID
	}
};

var response = client.Playlists.insert(
	new PlaylistsInsertRequest { Part = "snippet,status" },
	playlist
);

if (response.IsSuccessful)
{
	Console.WriteLine($"Playlist created: {response.Data.Id}");
}
```

## 🏗️ Project Structure

```
YouTubeSharp/
├── YouTubeSharp.Domain/
│   └── [Resource]/
│       ├── I[Resource].cs                    # Interface definitions
│       └── Models/
│           ├── Request/Root.cs               # Request models
│           └── Response/Root.cs              # Response models
│
├── YouTubeSharp.Infrastructure/
│   ├── [Resource]/
│   │   └── T[Resource].cs                    # Implementation classes
│   └── AuthorizationInterceptor.cs           # OAuth interceptor
│
├── YouTubeSharp/
│   ├── YouTubeClient.cs                      # Main client facade
│   ├── IYouTubeClient.cs                     # Client interface
│   └── credentials.json                      # OAuth credentials
│
└── YouTubeSharp.Application/
	└── Program.cs                            # Example usage
```

## 🤝 Contributing

Contributions are welcome! Please follow these guidelines:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Code Style

- Follow C# naming conventions (PascalCase for public members, camelCase for private)
- Use XML documentation comments for public APIs
- Keep methods focused and single-responsibility
- Write unit tests for new features

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🔗 Resources

- [YouTube Data API v3 Documentation](https://developers.google.com/youtube/v3)
- [Google API Client Library for .NET](https://github.com/googleapis/google-api-dotnet-client)
- [RestSharp Documentation](https://restsharp.dev/)

## 📞 Support

- **Issues**: Report bugs on [GitHub Issues](https://github.com/ydahan56/YouTubeSharp/issues)
- **Documentation**: Check the [Wiki](https://github.com/ydahan56/YouTubeSharp/wiki)
- **Email**: For inquiries, contact the maintainers

## 🎯 Roadmap

- [ ] Unit tests for all endpoints
- [ ] Async/await support throughout
- [ ] NuGet package publication
- [ ] API rate limiting helpers
- [ ] Batch operation support
- [ ] Webhook support for video updates
- [ ] Advanced filtering and pagination helpers

## 👏 Acknowledgments

- Built with [RestSharp](https://restsharp.dev/) for HTTP communication
- JSON handling by [Newtonsoft.Json](https://www.newtonsoft.com/json)
- OAuth 2.0 implementation using Google APIs
- Inspired by YouTube Data API v3 best practices

---

**Last Updated**: 2026
**Version**: 1.0.4
