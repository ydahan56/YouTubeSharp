using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace YouTubeSharp.Members.Models.Response
{
    public class Root
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#memberListResponse";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        [JsonProperty("prevPageToken")]
        public string? PrevPageToken { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        [JsonProperty("items")]
        public List<MemberItem> Items { get; set; } = new();
    }

    public class PageInfo
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage { get; set; }
    }

    public class MemberItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "youtube#member";

        [JsonProperty("etag")]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("snippet")]
        public MemberSnippet? Snippet { get; set; }
    }

    public class MemberSnippet
    {
        [JsonProperty("creatorChannelId")]
        public string CreatorChannelId { get; set; } = string.Empty;

        [JsonProperty("memberDetails")]
        public MemberDetails? MemberDetails { get; set; }

        [JsonProperty("membershipsDetails")]
        public MembershipsDetails? MembershipsDetails { get; set; }
    }

    public class MemberDetails
    {
        [JsonProperty("channelId")]
        public string ChannelId { get; set; } = string.Empty;

        [JsonProperty("channelUrl")]
        public string ChannelUrl { get; set; } = string.Empty;

        [JsonProperty("displayName")]
        public string DisplayName { get; set; } = string.Empty;

        [JsonProperty("profileImageUrl")]
        public string ProfileImageUrl { get; set; } = string.Empty;
    }

    public class MembershipsDetails
    {
        [JsonProperty("highestAccessibleLevel")]
        public string HighestAccessibleLevel { get; set; } = string.Empty;

        [JsonProperty("highestAccessibleLevelDisplayName")]
        public string HighestAccessibleLevelDisplayName { get; set; } = string.Empty;

        [JsonProperty("accessibleLevels")]
        public List<string> AccessibleLevels { get; set; } = new();

        [JsonProperty("membershipsDuration")]
        public MembershipsDuration? MembershipsDuration { get; set; }

        [JsonProperty("membershipsDurationAtLevels")]
        public List<MembershipsDurationAtLevel> MembershipsDurationAtLevels { get; set; } = new();
    }

    public class MembershipsDuration
    {
        [JsonProperty("memberSince")]
        public DateTime MemberSince { get; set; }

        [JsonProperty("memberTotalDurationMonths")]
        public int MemberTotalDurationMonths { get; set; }
    }

    public class MembershipsDurationAtLevel
    {
        [JsonProperty("level")]
        public string Level { get; set; } = string.Empty;

        [JsonProperty("memberSince")]
        public DateTime MemberSince { get; set; }

        [JsonProperty("memberTotalDurationMonths")]
        public int MemberTotalDurationMonths { get; set; }
    }
}