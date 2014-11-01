using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Transmission.
	/// </summary>
	public class Transmission
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.Transmission"/> class.
		/// </summary>
		public Transmission()
		{
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public int id{ get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string name{ get; set; }

		/// <summary>
		/// Gets or sets the type of the automatic.
		/// </summary>
		/// <value>The type of the automatic.</value>
		public string automaticType{ get; set; }

		/// <summary>
		/// Gets or sets the type of the transmission.
		/// </summary>
		/// <value>The type of the transmission.</value>
		public string transmissionType{ get; set; }

		/// <summary>
		/// Gets or sets the number of speeds.
		/// </summary>
		/// <value>The number of speeds.</value>
		public int numberOfSpeeds{ get; set; }
	}
}

