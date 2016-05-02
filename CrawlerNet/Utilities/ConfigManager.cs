using CrawlerNet.Models;
using CrawlerNet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerNet.Utilities
{
    public static class ConfigManager
    {
        public static void SetConfig(Config config)
        {
            var baseConfig = Properties.Settings.Default;
            
            baseConfig.crawlTimeoutSeconds = config.crawlTimeoutSeconds;
            baseConfig.downloadableContentTypes = config.downloadableContentTypes;
            baseConfig.httpRequestMaxAutoRedirects = config.httpRequestMaxAutoRedirects;
            baseConfig.httpRequestTimeoutInSeconds = config.httpRequestTimeoutInSeconds;
            baseConfig.httpServicePointConnectionLimit = config.httpServicePointConnectionLimit;
            baseConfig.isExternalPageCrawlingEnabled = config.isExternalPageCrawlingEnabled;
            baseConfig.isExternalPageLinksCrawlingEnabled = config.isExternalPageLinksCrawlingEnabled;
            baseConfig.isForcedLinkParsingEnabled = config.isForcedLinkParsingEnabled;
            baseConfig.isHttpRequestAutomaticDecompressionEnabled = config.isHttpRequestAutomaticDecompressionEnabled;
            baseConfig.isHttpRequestAutoRedirectsEnabled = config.isHttpRequestAutoRedirectsEnabled;
            baseConfig.isIgnoreRobotsDotTextIfRootDisallowedEnabled = config.isIgnoreRobotsDotTextIfRootDisallowedEnabled;
            baseConfig.isRespectAnchorRelNoFollowEnabled = config.isRespectAnchorRelNoFollowEnabled;
            baseConfig.isRespectMetaRobotsNoFollowEnabled = config.isRespectMetaRobotsNoFollowEnabled;
            baseConfig.isRespectRobotsDotTextEnabled = config.isRespectRobotsDotTextEnabled;
            baseConfig.isSendingCookiesEnabled = config.isSendingCookiesEnabled;
            baseConfig.isUriRecrawlingEnabled = config.isUriRecrawlingEnabled;
            baseConfig.maxConcurrentThreads = config.maxConcurrentThreads;
            baseConfig.maxCrawlDepth = config.maxCrawlDepth;
            baseConfig.maxMemoryUsageCacheTimeInSeconds = config.maxMemoryUsageCacheTimeInSeconds;
            baseConfig.maxMemoryUsageInMb = config.maxMemoryUsageInMb;
            baseConfig.maxPageSizeInBytes = config.maxPageSizeInBytes;
            baseConfig.maxPagesToCrawl = config.maxPagesToCrawl;
            baseConfig.maxPagesToCrawlPerDomain = config.maxPagesToCrawlPerDomain;
            baseConfig.maxRetryCount = config.maxRetryCount;
            baseConfig.maxRobotsDotTextCrawlDelayInSeconds = config.maxRobotsDotTextCrawlDelayInSeconds;
            baseConfig.minAvailableMemoryRequiredInMb = config.minAvailableMemoryRequiredInMb;
            baseConfig.minCrawlDelayPerDomainMilliSeconds = config.minCrawlDelayPerDomainMilliSeconds;
            baseConfig.minRetryDelayInMilliseconds = config.minRetryDelayInMilliseconds;
            baseConfig.robotsDotTextUserAgentString = config.robotsDotTextUserAgentString;
            baseConfig.userAgentString = config.userAgentString;

            baseConfig.Save();
        }

        public static Config GetConfig()
        {
            var baseConfig = Properties.Settings.Default;
            var config = new Config();

            config.crawlTimeoutSeconds = baseConfig.crawlTimeoutSeconds;
            config.downloadableContentTypes = baseConfig.downloadableContentTypes;
            config.httpRequestMaxAutoRedirects = baseConfig.httpRequestMaxAutoRedirects;
            config.httpRequestTimeoutInSeconds = baseConfig.httpRequestTimeoutInSeconds;
            config.httpServicePointConnectionLimit = baseConfig.httpServicePointConnectionLimit;
            config.isExternalPageCrawlingEnabled = baseConfig.isExternalPageCrawlingEnabled;
            config.isExternalPageLinksCrawlingEnabled = baseConfig.isExternalPageLinksCrawlingEnabled;
            config.isForcedLinkParsingEnabled = baseConfig.isForcedLinkParsingEnabled;
            config.isHttpRequestAutomaticDecompressionEnabled = baseConfig.isHttpRequestAutomaticDecompressionEnabled;
            config.isHttpRequestAutoRedirectsEnabled = baseConfig.isHttpRequestAutoRedirectsEnabled;
            config.isIgnoreRobotsDotTextIfRootDisallowedEnabled = baseConfig.isIgnoreRobotsDotTextIfRootDisallowedEnabled;
            config.isRespectAnchorRelNoFollowEnabled = baseConfig.isRespectAnchorRelNoFollowEnabled;
            config.isRespectMetaRobotsNoFollowEnabled = baseConfig.isRespectMetaRobotsNoFollowEnabled;
            config.isRespectRobotsDotTextEnabled = baseConfig.isRespectRobotsDotTextEnabled;
            config.isSendingCookiesEnabled = baseConfig.isSendingCookiesEnabled;
            config.isUriRecrawlingEnabled = baseConfig.isUriRecrawlingEnabled;
            config.maxConcurrentThreads = baseConfig.maxConcurrentThreads;
            config.maxCrawlDepth = baseConfig.maxCrawlDepth;
            config.maxMemoryUsageCacheTimeInSeconds = baseConfig.maxMemoryUsageCacheTimeInSeconds;
            config.maxMemoryUsageInMb = baseConfig.maxMemoryUsageInMb;
            config.maxPageSizeInBytes = baseConfig.maxPageSizeInBytes;
            config.maxPagesToCrawl = baseConfig.maxPagesToCrawl;
            config.maxPagesToCrawlPerDomain = baseConfig.maxPagesToCrawlPerDomain;
            config.maxRetryCount = baseConfig.maxRetryCount;
            config.maxRobotsDotTextCrawlDelayInSeconds = baseConfig.maxRobotsDotTextCrawlDelayInSeconds;
            config.minAvailableMemoryRequiredInMb = baseConfig.minAvailableMemoryRequiredInMb;
            config.minCrawlDelayPerDomainMilliSeconds = baseConfig.minCrawlDelayPerDomainMilliSeconds;
            config.minRetryDelayInMilliseconds = baseConfig.minRetryDelayInMilliseconds;
            config.robotsDotTextUserAgentString = baseConfig.robotsDotTextUserAgentString;
            config.userAgentString = baseConfig.userAgentString;

            return config;
        }
    }
}
