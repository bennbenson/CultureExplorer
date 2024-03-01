using System.Collections.Generic;
using System.Globalization;

namespace CultureExplorer.Models.NumberFormatViewModels;

public record class IndexViewModel(
	IEnumerable<CultureInfo> CultureInfos,
	IDictionary<CultureInfo, NumberFormatInfo> FormatInfos);
