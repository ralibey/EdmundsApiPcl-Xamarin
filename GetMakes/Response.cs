using System;

namespace EdmundsRestApi.GetMakes
{
	/// <summary>
	/// Response.
	/// </summary>
	public class Response
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EdmundsRestApi.GetMakes.Response"/> class.
		/// </summary>
		public Response()
		{
		}

		/// <summary>
		/// Gets or sets the makes.
		/// </summary>
		/// <value>The makes.</value>
		public Make[] Makes{ get; set; }

		/// <summary>
		/// Gets or sets the makes count.
		/// </summary>
		/// <value>The makes count.</value>
		public int MakesCount{ get; set; }
	}
}

