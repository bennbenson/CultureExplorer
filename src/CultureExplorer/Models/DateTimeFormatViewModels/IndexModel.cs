using System.Collections.Generic;
using System.Globalization;

namespace CultureExplorer.Models.DateTimeFormatViewModels;

public record class IndexViewModel(
	IEnumerable<CultureInfo> CultureInfos,
	IDictionary<CultureInfo, DateTimeFormatInfo> FormatInfos);
