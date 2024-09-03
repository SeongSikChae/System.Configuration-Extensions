namespace System.Configuration.Annotation
{
	/// <summary>
	/// Specifies rules for validation checks on other properties.
	/// </summary>
	/// <param name="type">Property Data Type for Validation</param>
	/// <param name="required">Whether it is a required value</param>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public sealed class PropertyAttribute(PropertyType type, bool required = false) : Attribute
	{
		/// <summary>
		/// Property Data Type for Validation
		/// </summary>
		public PropertyType Type => type;

		/// <summary>
		/// Whether it is a required value
		/// </summary>
		public bool Required => required;

		/// <summary>
		/// Parent Property Name
		/// If there is a parent property, it will not be watched if the parent property is invalid.
		/// </summary>
		public string? Parent { get; set; }

		/// <summary>
		/// Default value to be set when the property is not required
		/// </summary>
		public string? DefaultValue { get; set; }
	}

	/// <summary>
	/// Property Data Type for Validation
	/// </summary>
	public enum PropertyType
    {
		/// <summary>
		/// System.Boolean
		/// </summary>
        BOOL,
		/// <summary>
		/// System.Byte
		/// </summary>
        BYTE,
		/// <summary>
		/// System.SByte
		/// </summary>
        SBYTE,
		/// <summary>
		/// System.Int16
		/// </summary>
        SHORT,
		/// <summary>
		/// System.UInt16
		/// </summary>
        USHORT,
		/// <summary>
		/// System.Int32
		/// </summary>
        INT,
		/// <summary>
		/// System.UInt32
		/// </summary>
        UINT,
		/// <summary>
		/// System.Int64
		/// </summary>
        LONG,
		/// <summary>
		/// System.Int64
		/// </summary>
        ULONG,
		/// <summary>
		/// System.Double
		/// </summary>
        DOUBLE,
		/// <summary>
		/// System.String
		/// </summary>
        STRING
    }
}
