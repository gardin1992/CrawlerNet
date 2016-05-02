using Abot.Poco;
using CrawlerNet.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrawlerNet.Crawler
{
    public interface ICrawlerNetConfig
    {
        CrawlConfiguration Initalize();
    }

    public class CrawlerNetConfig
        : ICrawlerNetConfig
    {
        public readonly CrawlConfiguration config = null;
        public CrawlerNetConfig()
        {
            this.config = new CrawlConfiguration();
        }
        public CrawlConfiguration Initalize()
        {
            var baseConfig = ConfigManager.GetConfig();

            config.CrawlTimeoutSeconds = baseConfig.crawlTimeoutSeconds;
            config.DownloadableContentTypes = baseConfig.downloadableContentTypes;
            config.HttpRequestMaxAutoRedirects = baseConfig.httpRequestMaxAutoRedirects;
            config.HttpRequestTimeoutInSeconds = baseConfig.httpRequestTimeoutInSeconds;
            config.HttpServicePointConnectionLimit = baseConfig.httpServicePointConnectionLimit;
            config.IsExternalPageCrawlingEnabled = baseConfig.isExternalPageCrawlingEnabled;
            config.IsExternalPageLinksCrawlingEnabled = baseConfig.isExternalPageLinksCrawlingEnabled;
            config.IsForcedLinkParsingEnabled = baseConfig.isForcedLinkParsingEnabled;
            config.IsHttpRequestAutomaticDecompressionEnabled = baseConfig.isHttpRequestAutomaticDecompressionEnabled;
            config.IsHttpRequestAutoRedirectsEnabled = baseConfig.isHttpRequestAutoRedirectsEnabled;
            config.IsIgnoreRobotsDotTextIfRootDisallowedEnabled = baseConfig.isIgnoreRobotsDotTextIfRootDisallowedEnabled;
            config.IsRespectAnchorRelNoFollowEnabled = baseConfig.isRespectAnchorRelNoFollowEnabled;
            config.IsRespectMetaRobotsNoFollowEnabled = baseConfig.isRespectMetaRobotsNoFollowEnabled;
            config.IsRespectRobotsDotTextEnabled = baseConfig.isRespectRobotsDotTextEnabled;
            config.IsSendingCookiesEnabled = baseConfig.isSendingCookiesEnabled;
            config.IsUriRecrawlingEnabled = baseConfig.isUriRecrawlingEnabled;
            config.MaxConcurrentThreads = baseConfig.maxConcurrentThreads;
            config.MaxCrawlDepth = baseConfig.maxCrawlDepth;
            config.MaxMemoryUsageCacheTimeInSeconds = baseConfig.maxMemoryUsageCacheTimeInSeconds;
            config.MaxMemoryUsageInMb = baseConfig.maxMemoryUsageInMb;
            config.MaxPageSizeInBytes = baseConfig.maxPageSizeInBytes;
            config.MaxPagesToCrawl = baseConfig.maxPagesToCrawl;
            config.MaxPagesToCrawlPerDomain = baseConfig.maxPagesToCrawlPerDomain;
            config.MaxRetryCount = baseConfig.maxRetryCount;
            config.MaxRobotsDotTextCrawlDelayInSeconds = baseConfig.maxRobotsDotTextCrawlDelayInSeconds;
            config.MinAvailableMemoryRequiredInMb = baseConfig.minAvailableMemoryRequiredInMb;
            config.MinCrawlDelayPerDomainMilliSeconds = baseConfig.minCrawlDelayPerDomainMilliSeconds;
            config.MinRetryDelayInMilliseconds = baseConfig.minRetryDelayInMilliseconds;
            config.RobotsDotTextUserAgentString = baseConfig.robotsDotTextUserAgentString;
            config.UserAgentString = baseConfig.userAgentString;

            return config;
            
        }
    }
}