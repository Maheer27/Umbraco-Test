using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbraco.BLL
{
	public class MetaDataViewModel
	{
		public string Prefix { get; set; }

		public string TitleTag { get; set; }

		public string DescriptionTag { get; set; }

		public string KeywordTag { get; set; }

		public List<MetaDataItemBase> Tags { get; set; }
	}
}
