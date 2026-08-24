using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core.DTO.GitHub
{
	public class GitHubContent
	{
		public string Name { get; set; } = string.Empty;
		public string Path { get; set; } = string.Empty;
		public string Sha { get; set; } = string.Empty;
		public string Url { get; set; } = string.Empty;
		public string HtmlUrl { get; set; } = string.Empty;
		public string GitUrl { get; set; } = string.Empty;
		public string DownloadUrl { get; set; } = string.Empty;
		public string Type { get; set; } = string.Empty;
		public string Content { get; set; } = string.Empty;
		public int Size { get; set; } = 0;
	}
}
