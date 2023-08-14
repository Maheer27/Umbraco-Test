using System.Text.Json.Serialization;

namespace Umbraco.BLL
{
	interface IViewModelBase
	{
		MetaDataViewModel MetaDataViewModel { get; set; }
	}

	public class ViewModelBase : IViewModelBase
	{
		[JsonIgnore]
		public MetaDataViewModel MetaDataViewModel { get; set; }
	}
}