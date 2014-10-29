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

	}
}

