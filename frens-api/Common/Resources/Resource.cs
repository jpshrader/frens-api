using System.Collections.Generic;

namespace frens_api.Common.Resources {
	public abstract class Resource {
		public IEnumerable<HateoasLink> Links { get; set; }
	}
}
