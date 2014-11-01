using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Options.
	/// </summary>
	public class VehicleOptions
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EdmundsRestApi.GetStyles.VehicleOptions"/> class.
		/// </summary>
		public VehicleOptions()
		{
		}

		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		/// <value>The category.</value>
		public string Category { get; set; }

		/// <summary>
		/// Gets or sets the options.
		/// </summary>
		/// <value>The options.</value>
		public Option[] Options{ get; set; }
	}
}

