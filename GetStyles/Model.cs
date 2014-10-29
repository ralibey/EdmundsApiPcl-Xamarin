using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Model.
	/// </summary>
	public class Model
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EdmundsRestApi.GetMakes.Model"/> class.
		/// </summary>
		public Model()
		{
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public string Id{ get; set; }

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

