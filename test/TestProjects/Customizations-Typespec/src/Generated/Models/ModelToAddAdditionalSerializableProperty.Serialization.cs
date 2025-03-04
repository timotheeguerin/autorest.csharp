// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace CustomizationsInCadl.Models
{
    public partial class ModelToAddAdditionalSerializableProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("requiredInt"u8);
            WriteRequiredIntValue(writer);
            if (Optional.IsDefined(AdditionalSerializableProperty))
            {
                writer.WritePropertyName("additionalSerializableProperty"u8);
                writer.WriteNumberValue(AdditionalSerializableProperty);
            }
            if (Optional.IsDefined(AdditionalNullableSerializableProperty))
            {
                if (AdditionalNullableSerializableProperty != null)
                {
                    writer.WritePropertyName("additionalNullableSerializableProperty"u8);
                    writer.WriteNumberValue(AdditionalNullableSerializableProperty.Value);
                }
                else
                {
                    writer.WriteNull("additionalNullableSerializableProperty");
                }
            }
            writer.WriteEndObject();
        }

        internal static ModelToAddAdditionalSerializableProperty DeserializeModelToAddAdditionalSerializableProperty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int requiredInt = default;
            Optional<int> additionalSerializableProperty = default;
            Optional<int?> additionalNullableSerializableProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requiredInt"u8))
                {
                    DeserializeRequiredIntValue(property, ref requiredInt);
                    continue;
                }
                if (property.NameEquals("additionalSerializableProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalSerializableProperty = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("additionalNullableSerializableProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        additionalNullableSerializableProperty = null;
                        continue;
                    }
                    additionalNullableSerializableProperty = property.Value.GetInt32();
                    continue;
                }
            }
            return new ModelToAddAdditionalSerializableProperty(requiredInt, additionalSerializableProperty, Optional.ToNullable(additionalNullableSerializableProperty));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ModelToAddAdditionalSerializableProperty FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeModelToAddAdditionalSerializableProperty(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
