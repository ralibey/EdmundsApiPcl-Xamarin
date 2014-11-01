using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Categories.
	/// </summary>
	public class Categories
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.Categories"/> class.
		/// </summary>
		public Categories()
		{
		}

		/// <summary>
		/// Gets or sets the EPA class.
		/// </summary>
		/// <value>The EPA class.</value>
		public string EPAClass{ get; set; }

		/// <summary>
		/// Gets or sets the size of the vehicle.
		/// </summary>
		/// <value>The size of the vehicle.</value>
		public string VehicleSize{ get; set; }

		/// <summary>
		/// Gets or sets the type of the primary body.
		/// </summary>
		/// <value>The type of the primary body.</value>
		public string PrimaryBodyType{ get; set; }

		/// <summary>
		/// Gets or sets the vehicle style.
		/// </summary>
		/// <value>The vehicle style.</value>
		public string VehicleStyle{ get; set; }

		/// <summary>
		/// Gets or sets the type of the vehicle.
		/// </summary>
		/// <value>The type of the vehicle.</value>
		public string VehicleType{ get; set; }
	}
}

