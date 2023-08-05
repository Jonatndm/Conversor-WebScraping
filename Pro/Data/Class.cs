using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.Linq;

namespace Pro.Data
{
	public class Class
	{
		public HtmlWeb web;
		public HtmlDocument doc;
		public HtmlNode body;

		public Class(string url)
		{
			this.web = new HtmlWeb();
			this.doc = web.Load(url);
			this.body = doc.DocumentNode.CssSelect(".YMlKec.fxKbKc").First();
			
		}

	}
}
