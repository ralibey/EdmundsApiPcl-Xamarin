using System;

namespace EdmundsRestApi.GetStyles
{
	/// <summary>
	/// Engine.
	/// </summary>
	public class Engine
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.Engine"/> class.
		/// </summary>
		public Engine()
		{
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public string Id{ get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name{ get; set; }

		/// <summary>
		/// Gets or sets the compression ratio.
		/// </summary>
		/// <value>The compression ratio.</value>
		public float CompressionRatio{ get; set; }

		/// <summary>
		/// Gets or sets the cylinder.
		/// </summary>
		/// <value>The cylinder.</value>
		public int Cylinder{ get; set; }

		/// <summary>
		/// Gets or sets the size.
		/// </summary>
		/// <value>The size.</value>
		public float Size{ get; set; }

		/// <summary>
		/// Gets or sets the displacement.
		/// </summary>
		/// <value>The displacement.</value>
		public string Displacement{ get; set; }

		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
		public string Configuration{ get; set; }

		/// <summary>
		/// Gets or sets the type of the fuel.
		/// </summary>
		/// <value>The type of the fuel.</value>
		public string FuelType{ get; set; }

		/// <summary>
		/// Gets or sets the horsepower.
		/// </summary>
		/// <value>The horsepower.</value>
		public int Horsepower{ get; set; }

		/// <summary>
		/// Gets or sets the torque.
		/// </summary>
		/// <value>The torque.</value>
		public int Torque{ get; set; }

		/// <summary>
		/// Gets or sets the total valves.
		/// </summary>
		/// <value>The total valves.</value>
		public int TotalValves{ get; set; }

		/// <summary>
		/// Gets or sets the manufacturer engine code.
		/// </summary>
		/// <value>The manufacturer engine code.</value>
		public string ManufacturerEngineCode{ get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string Type{ get; set; }

		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		/// <value>The code.</value>
		public string Code{ get; set; }

		/// <summary>
		/// Gets or sets the type of the compressor.
		/// </summary>
		/// <value>The type of the compressor.</value>
		public string CompressorType{ get; set; }
	}
}

