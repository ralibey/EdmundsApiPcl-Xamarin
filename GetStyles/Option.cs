using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Option.
	/// </summary>
	public class Option
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.Option"/> class.
		/// </summary>
		public Option()
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
		/// Gets or sets the type of the equipment.
		/// </summary>
		/// <value>The type of the equipment.</value>
		public string EquipmentType{ get; set; }

		/// <summary>
		/// Gets or sets the name of the manufacture option.
		/// </summary>
		/// <value>The name of the manufacture option.</value>
		public string ManufactureOptionName{ get; set; }

		/// <summary>
		/// Gets or sets the manufacture option code.
		/// </summary>
		/// <value>The manufacture option code.</value>
		public string ManufactureOptionCode{ get; set; }

		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		/// <value>The category.</value>
		public string Category{ get; set; }
	}
}

