using System;

namespace EdmundsRestApi.GetMakes
{
	/// <summary>
	/// Model year.
	/// </summary>
	public class ModelYear
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EdmundsRestApi.GetMakes.ModelYear"/> class.
		/// </summary>
		public ModelYear()
		{
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the states.
		/// </summary>
		/// <value>The states.</value>
		public string[] States { get; set; }

		/// <summary>
		/// Gets or sets the year.
		/// </summary>
		/// <value>The year.</value>
		public int Year{ get; set; }
	}
}

