// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ObjectWithDeprecatedFields
    /// </summary>
    public partial class ObjectWithDeprecatedFields : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectWithDeprecatedFields" /> class.
        /// </summary>
        /// <param name="bars">bars</param>
        /// <param name="deprecatedRef">deprecatedRef</param>
        /// <param name="id">id</param>
        /// <param name="uuid">uuid</param>
        [JsonConstructor]
        public ObjectWithDeprecatedFields(Option<List<string>> bars = default, Option<DeprecatedObject> deprecatedRef = default, Option<decimal?> id = default, Option<string> uuid = default)
        {
            BarsOption = bars;
            DeprecatedRefOption = deprecatedRef;
            IdOption = id;
            UuidOption = uuid;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Bars
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>> BarsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Bars
        /// </summary>
        [JsonPropertyName("bars")]
        [Obsolete]
        public List<string> Bars { get { return this.BarsOption; } set { this.BarsOption = new Option<List<string>>(value); } }

        /// <summary>
        /// Used to track the state of DeprecatedRef
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DeprecatedObject> DeprecatedRefOption { get; private set; }

        /// <summary>
        /// Gets or Sets DeprecatedRef
        /// </summary>
        [JsonPropertyName("deprecatedRef")]
        [Obsolete]
        public DeprecatedObject DeprecatedRef { get { return this.DeprecatedRefOption; } set { this.DeprecatedRefOption = new Option<DeprecatedObject>(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        [Obsolete]
        public decimal? Id { get { return this.IdOption; } set { this.IdOption = new Option<decimal?>(value); } }

        /// <summary>
        /// Used to track the state of Uuid
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> UuidOption { get; private set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get { return this.UuidOption; } set { this.UuidOption = new Option<string>(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObjectWithDeprecatedFields {\n");
            sb.Append("  Bars: ").Append(Bars).Append("\n");
            sb.Append("  DeprecatedRef: ").Append(DeprecatedRef).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ObjectWithDeprecatedFields" />
    /// </summary>
    public class ObjectWithDeprecatedFieldsJsonConverter : JsonConverter<ObjectWithDeprecatedFields>
    {
        /// <summary>
        /// Deserializes json to <see cref="ObjectWithDeprecatedFields" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ObjectWithDeprecatedFields Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>> bars = default;
            Option<DeprecatedObject> deprecatedRef = default;
            Option<decimal?> id = default;
            Option<string> uuid = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "bars":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                bars = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "deprecatedRef":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                deprecatedRef = new Option<DeprecatedObject>(JsonSerializer.Deserialize<DeprecatedObject>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "uuid":
                            uuid = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (bars.IsSet && bars.Value == null)
                throw new ArgumentNullException(nameof(bars), "Property is not nullable for class ObjectWithDeprecatedFields.");

            if (deprecatedRef.IsSet && deprecatedRef.Value == null)
                throw new ArgumentNullException(nameof(deprecatedRef), "Property is not nullable for class ObjectWithDeprecatedFields.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ObjectWithDeprecatedFields.");

            if (uuid.IsSet && uuid.Value == null)
                throw new ArgumentNullException(nameof(uuid), "Property is not nullable for class ObjectWithDeprecatedFields.");

            return new ObjectWithDeprecatedFields(bars, deprecatedRef, id, uuid);
        }

        /// <summary>
        /// Serializes a <see cref="ObjectWithDeprecatedFields" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="objectWithDeprecatedFields"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ObjectWithDeprecatedFields objectWithDeprecatedFields, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, objectWithDeprecatedFields, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ObjectWithDeprecatedFields" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="objectWithDeprecatedFields"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ObjectWithDeprecatedFields objectWithDeprecatedFields, JsonSerializerOptions jsonSerializerOptions)
        {
            if (objectWithDeprecatedFields.BarsOption.IsSet && objectWithDeprecatedFields.Bars == null)
                throw new ArgumentNullException(nameof(objectWithDeprecatedFields.Bars), "Property is required for class ObjectWithDeprecatedFields.");

            if (objectWithDeprecatedFields.DeprecatedRefOption.IsSet && objectWithDeprecatedFields.DeprecatedRef == null)
                throw new ArgumentNullException(nameof(objectWithDeprecatedFields.DeprecatedRef), "Property is required for class ObjectWithDeprecatedFields.");

            if (objectWithDeprecatedFields.UuidOption.IsSet && objectWithDeprecatedFields.Uuid == null)
                throw new ArgumentNullException(nameof(objectWithDeprecatedFields.Uuid), "Property is required for class ObjectWithDeprecatedFields.");

            if (objectWithDeprecatedFields.BarsOption.IsSet)
            {
                writer.WritePropertyName("bars");
                JsonSerializer.Serialize(writer, objectWithDeprecatedFields.Bars, jsonSerializerOptions);
            }
            if (objectWithDeprecatedFields.DeprecatedRefOption.IsSet)
            {
                writer.WritePropertyName("deprecatedRef");
                JsonSerializer.Serialize(writer, objectWithDeprecatedFields.DeprecatedRef, jsonSerializerOptions);
            }
            if (objectWithDeprecatedFields.IdOption.IsSet)
                writer.WriteNumber("id", objectWithDeprecatedFields.IdOption.Value.Value);

            if (objectWithDeprecatedFields.UuidOption.IsSet)
                writer.WriteString("uuid", objectWithDeprecatedFields.Uuid);
        }
    }
}
