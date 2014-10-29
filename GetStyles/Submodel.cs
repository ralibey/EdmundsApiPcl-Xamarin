using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Sub model.
	/// </summary>
	public class SubModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.SubModel"/> class.
		/// </summary>
		public SubModel()
		{

		}

		/// <summary>
		/// Gets or sets the body.
		/// </summary>
		/// <value>The body.</value>
		public string Body{ get; set; }

		/// <summary>
		/// Gets or sets the fuel.
		/// </summary>
		/// <value>The fuel.</value>
		public string Fuel{ get; set; }

		/// <summary>
		/// Gets or sets the tuner.
		/// </summary>
		/// <value>The tuner.</value>
		public string Tuner{ get; set; }

		/// <summary>
		/// Gets or sets the name of the model.
		/// </summary>
		/// <value>The name of the model.</value>
		public string ModelName{ get; set; }

		/// <summary>
		/// Gets or sets the name of the nice.
		/// </summary>
		/// <value>The name of the nice.</value>
		public string NiceName{ get; set; }
	}
}

