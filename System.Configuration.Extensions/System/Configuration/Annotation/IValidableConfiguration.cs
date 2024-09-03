namespace System.Configuration.Annotation
{
	/// <summary>
	/// Interface for custom validation other than PropertyAttribute
	/// </summary>
	public interface IValidatableConfiguration
    {
		/// <summary>
		/// When performing custom validation, you must implement the corresponding method and throw the necessary exception when validation fails.
		/// </summary>
		void Validate();
    }
}
