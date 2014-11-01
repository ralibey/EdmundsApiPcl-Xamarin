using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Style.
	/// </summary>
	public class Style
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.Style"/> class.
		/// </summary>
		public Style()
		{
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public int Id{ get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name{ get; set; }

		/// <summary>
		/// Gets or sets the trim.
		/// </summary>
		/// <value>The trim.</value>
		public string Trim { get; set; }

		/// <summary>
		/// Gets or sets the make.
		/// </summary>
		/// <value>The make.</value>
		public Make Make{ get; set; }

		/// <summary>
		/// Gets or sets the model.
		/// </summary>
		/// <value>The model.</value>
		public Model Model{ get; set; }

		/// <summary>
		/// Gets or sets the year.
		/// </summary>
		/// <value>The year.</value>
		public ModelYear Year{ get; set; }

		/// <summary>
		/// Gets or sets the sub model.
		/// </summary>
		/// <value>The sub model.</value>
		public SubModel SubModel{ get; set; }

		/// <summary>
		/// Gets or sets the states.
		/// </summary>
		/// <value>The states.</value>
		public string[] States{ get; set; }

		/// <summary>
		/// Gets or sets the engine.
		/// </summary>
		/// <value>The engine.</value>
		public Engine Engine{ get; set; }

		/// <summary>
		/// Gets or sets the transmission.
		/// </summary>
		/// <value>The transmission.</value>
		public Transmission Transmission{ get; set; }

		/// <summary>
		/// Gets or sets the options.
		/// </summary>
		/// <value>The options.</value>
		public VehicleOptions[] Options{ get; set; }

		/// <summary>
		/// Gets or sets the colors.
		/// </summary>
		/// <value>The colors.</value>
		public Colors[] Colors{ get; set; }

		/// <summary>
		/// Gets or sets the driven wheels.
		/// </summary>
		/// <value>The driven wheels.</value>
		public string DrivenWheels{ get; set; }

		/// <summary>
		/// Gets or sets the number of doors.
		/// </summary>
		/// <value>The number of doors.</value>
		public string NumOfDoors{ get; set; }

		/// <summary>
		/// Gets or sets the squish vins.
		/// </summary>
		/// <value>The squish vins.</value>
		public string[] SquishVins{ get; set; }

		/// <summary>
		/// Gets or sets the categories.
		/// </summary>
		/// <value>The categories.</value>
		public Categories Categories{ get; set; }

		/// <summary>
		/// Gets or sets the MP.
		/// </summary>
		/// <value>The MP.</value>
		public FuelEfficiency MPG{ get; set; }

		/// <summary>
		/// Gets or sets the manufacturer code.
		/// </summary>
		/// <value>The manufacturer code.</value>
		public string ManufacturerCode{ get; set; }

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		/// <value>The price.</value>
		public Pricing Price{ get; set; }

		/// <summary>
		/// Gets or sets the display.
		/// </summary>
		/// <value>The display.</value>
		public string Display{ get { return string.Format("{0}\n{1}", Trim, Name); } }

	}
}

