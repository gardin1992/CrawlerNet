using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrawlerNet.Models
{
    public class Config
        : BaseModel
    {
        // crawlBehavior 
        public int maxConcurrentThreads { get; set; }
        public int maxPagesToCrawl { get; set; }
        public int maxPagesToCrawlPerDomain { get; set; }
        public int maxPageSizeInBytes { get; set; }
        public string userAgentString { get; set; }
        public int crawlTimeoutSeconds { get; set; }
        public string downloadableContentTypes { get; set; }
        public bool isUriRecrawlingEnabled { get; set; }
        public bool isExternalPageCrawlingEnabled { get; set; }
        public bool isExternalPageLinksCrawlingEnabled { get; set; }
        public int httpServicePointConnectionLimit { get; set; }
        public int httpRequestTimeoutInSeconds { get; set; }
        public int httpRequestMaxAutoRedirects { get; set; }
        public bool isHttpRequestAutoRedirectsEnabled { get; set; }
        public bool isHttpRequestAutomaticDecompressionEnabled { get; set; }
        public bool isSendingCookiesEnabled { get; set; }
        public int minAvailableMemoryRequiredInMb { get; set; }
        public int maxMemoryUsageInMb { get; set; }
        public int maxMemoryUsageCacheTimeInSeconds { get; set; }
        public int maxCrawlDepth { get; set; }
        public bool isForcedLinkParsingEnabled { get; set; }
        public int maxRetryCount { get; set; }
        public int minRetryDelayInMilliseconds { get; set; }

        // politeness 
        public bool isRespectRobotsDotTextEnabled { get; set; }
        public bool isRespectMetaRobotsNoFollowEnabled { get; set; }
        public bool isRespectAnchorRelNoFollowEnabled { get; set; }
        public bool isIgnoreRobotsDotTextIfRootDisallowedEnabled { get; set; }
        public string robotsDotTextUserAgentString { get; set; }
        public int maxRobotsDotTextCrawlDelayInSeconds { get; set; }
        public int minCrawlDelayPerDomainMilliSeconds { get; set; }


    }
}