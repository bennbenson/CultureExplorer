using System.Collections.Generic;
using System.Globalization;

namespace CultureExplorer.Models.TextViewModels
{
	public class IndexModel
	{
		public IndexModel()
		{
		}

		public IndexModel(IndexModel model)
		{
			if (model != null)
			{
			}
		}
	}

	public class IndexViewModel : IndexModel
	{
		public IndexViewModel()
		{
		}

		public IndexViewModel(IndexModel model)
			: base(model)
		{
			if (model is IndexViewModel viewModel)
			{
				CultureInfos = viewModel.CultureInfos;
				FormatInfos = viewModel.FormatInfos;
			}
		}


		public IEnumerable<CultureInfo> CultureInfos { get; set; }
		public IDictionary<CultureInfo, TextInfo> FormatInfos { get; set; }
	}
}
