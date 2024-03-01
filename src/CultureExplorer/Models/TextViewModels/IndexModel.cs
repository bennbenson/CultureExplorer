using System.Collections.Generic;
using System.Globalization;

namespace CultureExplorer.Models.TextViewModels;

public record class IndexViewModel(
	IEnumerable<CultureInfo> CultureInfos,
	IDictionary<CultureInfo, TextInfo> FormatInfos);
