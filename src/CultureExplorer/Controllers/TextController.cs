using System.Globalization;
using System.Linq;
using CultureExplorer.Models.TextViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CultureExplorer.Controllers;

public class TextController : Controller
{
	private static readonly string[] _cultureNames = ["", "en-US", "en-UK", "de-DE", "fr-FR", "es-ES", "it-IT", "ru-RU", "jp-JP"];


	public IActionResult Index()
	{
		var cultureInfos = _cultureNames.Select(name => CultureInfo.GetCultureInfo(name)).ToList();

		var formatInfos = cultureInfos.ToDictionary(x => x, x => x.TextInfo);

		IndexViewModel viewModel = new IndexViewModel(cultureInfos, formatInfos);

		return View(viewModel);
	}
}
