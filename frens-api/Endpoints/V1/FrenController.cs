using frens_api.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace frens_api.Endpoints.V1 {
	[ApiController]
	[ApiVersion1]
	public class FrenController : ControllerBase {
		public const string ROUTE = ApiConstants.BASE_URL + "/frens";
		public const string ROUTE_SINGLE = ROUTE + "/{frenId}";

		[HttpGet(ROUTE_SINGLE)]
		public IActionResult Get(string frenId) {
			return Ok(frenId);
		}
	}
}
