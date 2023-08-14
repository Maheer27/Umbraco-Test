using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbraco.BLL
{
	public abstract class MetaDataItemBase
	{
		//public abstract IHtmlString GetHtmlString();
		public abstract HtmlString GetHtmlString();
	}
}
