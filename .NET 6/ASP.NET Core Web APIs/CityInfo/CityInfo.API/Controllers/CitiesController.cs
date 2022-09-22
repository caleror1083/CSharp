using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CityInfo.API.Controllers
	{
		[ApiController] // applying this attribute configures the controller with features and behaviors aimed at improving the development experience
		public class CitiesController : ControllerBase  // ControllerBase contains basic functionality controllers needed to provide access to the model state, the current user and common methods for returning responses
			{
				public JsonResult GetCities() // method that returns data
					{
						new JsonResult(
						    new List<object> {
							    new { id = 1, Name = "New York City" },
								new { id = 2, Name = "Antwerp" }
							});
					
					}
			}
	}