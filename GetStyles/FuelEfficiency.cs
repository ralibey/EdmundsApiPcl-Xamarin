using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Fuel efficiency.
	/// </summary>
	public class FuelEfficiency
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EdmundsRestApi.GetStyles.FuelEfficiency"/> class.
		/// </summary>
		public FuelEfficiency()
		{
		}

		/// <summary>
		/// Gets or sets the highway.
		/// </summary>
		/// <value>The highway.</value>
		public string Highway{ get; set; }

		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City{ get; set; }
	}
}

