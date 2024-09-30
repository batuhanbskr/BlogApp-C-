using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreDemo.ViewModels
{
	public class IlViewModel
	{
		public int SecilenIlId { get; set; }
		public List<SelectListItem> Iller { get; set; }
	}
}
