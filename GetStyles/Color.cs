using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Color option.
	/// </summary>
	public class Color
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.ColorOption"/> class.
		/// </summary>
		public Color()
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

		/// <summary>
		/// Gets or sets the color chips.
		/// </summary>
		/// <value>The color chips.</value>
		public ColorChip ColorChips{ get; set; }

		/// <summary>
		/// Gets or sets the type of the fabric.
		/// </summary>
		/// <value>The type of the fabric.</value>
		public string FabricType{ get; set; }
	}

	/// <summary>
	/// Color detail.
	/// </summary>
	public class ColorDetail
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.ColorDetail"/> class.
		/// </summary>
		public ColorDetail()
		{

		}

		/// <summary>
		/// Gets or sets the r.
		/// </summary>
		/// <value>The r.</value>
		public int R { get; set; }

		/// <summary>
		/// Gets or sets the g.
		/// </summary>
		/// <value>The g.</value>
		public int G{ get; set; }

		/// <summary>
		/// Gets or sets the b.
		/// </summary>
		/// <value>The b.</value>
		public int B{ get; set; }

		/// <summary>
		/// Gets or sets the hex.
		/// </summary>
		/// <value>The hex.</value>
		public string Hex{ get; set; }
	}

	/// <summary>
	/// Color chip.
	/// </summary>
	public class ColorChip
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.ColorChip"/> class.
		/// </summary>
		public ColorChip()
		{
		}

		/// <summary>
		/// Gets or sets the primary.
		/// </summary>
		/// <value>The primary.</value>
		public ColorDetail Primary{ get; set; }
	}
}

