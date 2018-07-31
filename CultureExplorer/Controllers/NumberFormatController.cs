﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CultureExplorer.Models.NumberFormatViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CultureExplorer.Controllers
{
	public class NumberFormatController : Controller
	{
		private static readonly	string[] _cultureNames = new string[] { "", "en-US", "en-UK", "de-DE", "fr-FR", "es-ES", "it-IT", "ru-RU", "jp-JP" };


		public IActionResult Index()
		{
			var cultureInfos = _cultureNames.Select(name => CultureInfo.GetCultureInfo(name)).ToList();

			var formatInfos = cultureInfos.ToDictionary(x => x, x => x.NumberFormat);

			IndexViewModel viewModel = new IndexViewModel
			{
				CultureInfos = cultureInfos,
				FormatInfos = formatInfos
			};

			return View(viewModel);
		}
	}
}
