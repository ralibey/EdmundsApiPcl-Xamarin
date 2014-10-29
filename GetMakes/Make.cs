using System;

namespace EdmundsRestApi.GetMakes
{
	/// <summary>
	/// Make.
	/// </summary>
	public class Make
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EdmundsRestApi.GetMakes.Make"/> class.
		/// </summary>
		public Make()
		{
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public int Id{ get; set; }

		/// <summary>
		/// Gets or sets the models.
		/// </summary>
		/// <value>The models.</value>
		public Model[] Models{ get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name{ get; set; }

		/// <summary>
		/// Gets or sets the name of the nice.
		/// </summary>
		/// <value>The name of the nice.</value>
		public string NiceName{ get; set; }
	}
}

