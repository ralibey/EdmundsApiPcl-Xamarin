using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Response.
	/// </summary>
	public class Response
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.Response"/> class.
		/// </summary>
		public Response()
		{
		}

		/// <summary>
		/// Gets or sets the styles.
		/// </summary>
		/// <value>The styles.</value>
		public Style[] Styles{ get; set; }
	}
}
