using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Price.
	/// </summary>
	public class Pricing
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EdmundsRestApi.GetStyles.Pricing"/> class.
		/// </summary>
		public Pricing()
		{
		}

		/// <summary>
		/// Gets or sets the base MSR.
		/// </summary>
		/// <value>The base MSR.</value>
		public float BaseMSRP{ get; set; }

		/// <summary>
		/// Gets or sets the base invoice.
		/// </summary>
		/// <value>The base invoice.</value>
		public float BaseInvoice{ get; set; }

		/// <summary>
		/// Gets or sets the delivery charges.
		/// </summary>
		/// <value>The delivery charges.</value>
		public float DeliveryCharges{ get; set; }

		/// <summary>
		/// Gets or sets the used tmv retail.
		/// </summary>
		/// <value>The used tmv retail.</value>
		public float UsedTmvRetail{ get; set; }

		/// <summary>
		/// Gets or sets the used private party.
		/// </summary>
		/// <value>The used private party.</value>
		public float UsedPrivateParty{ get; set; }

		/// <summary>
		/// Gets or sets the used trade in.
		/// </summary>
		/// <value>The used trade in.</value>
		public float UsedTradeIn{ get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="EdmundsRestApi.GetStyles.Price"/> estimate tmv.
		/// </summary>
		/// <value><c>true</c> if estimate tmv; otherwise, <c>false</c>.</value>
		public bool EstimateTmv{ get; set; }

		/// <summary>
		/// Gets or sets the tmv recommended rating.
		/// </summary>
		/// <value>The tmv recommended rating.</value>
		public int TmvRecommendedRating{ get; set; }
	}
}

