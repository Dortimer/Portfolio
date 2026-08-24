using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.Constants
{
	public static class GitHubConstants
	{
		public const string BaseUrl = "https://api.github.com/";
		public const string Version = "2026-03-10";
		public const string OwnerName = "Dortimer";
		public const string RepoName = "Portfolio";
		public const string Accept = "application/vnd.github+json";
		
		public static class ContentType
		{
			public static string Directory ="dir";
			public static string File = "file";
		}
	}
}
