namespace WhatIsHeDoing.DomainModels
{
    using System.Xml.Serialization;

    /// <summary>
    /// Domain model contract, used to enforce useful
    /// common features and de/serialisation from JSON and XML.
    /// </summary>
    public interface IDomainModel<T> : IXmlSerializable
    {
        /// <summary>
        /// Raw value.
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Assigns the value from an object to this one.
        /// </summary>
        /// <param name="value">To inspect and assign</param>
        /// <returns>This</returns>
        IDomainModel<T> AssignFrom(object value);

        /// <summary>
        /// Converts the model to string.
        /// </summary>
        /// <returns>String respresentation</returns>
        string ToString();

        /// <summary>
        /// Determines if a model is valid.
        /// </summary>
        /// <param name="value">To validate</param>
        /// <returns>Validity</returns>
        bool TryValidate(T value);

        /// <summary>
        /// Throws if a value is invalid.
        /// </summary>
        /// <param name="value">To validate</param>
        /// <returns>Domain model</returns>
        IDomainModel<T> Validate(T value);
    }
}
