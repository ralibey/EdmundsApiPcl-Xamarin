using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Colors.
	/// </summary>
	public class Colors
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EdmundsRestApi.GetStyles.Colors"/> class.
		/// </summary>
		public Colors()
		{
		}

		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		/// <value>The category.</value>
		public string Category{ get; set; }

		/// <summary>
		/// Gets or sets the options.
		/// </summary>
		/// <value>The options.</value>
		public Color[] Options{ get; set; }
	}
}

