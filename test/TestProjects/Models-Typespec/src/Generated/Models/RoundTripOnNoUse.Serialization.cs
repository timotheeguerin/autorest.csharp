// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace ModelsInCadl.Models
{
    public partial class RoundTripOnNoUse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("requiredCollection"u8);
            writer.WriteStartArray();
            foreach (var item in RequiredCollection)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("baseModelProp"u8);
            writer.WriteStringValue(BaseModelProp);
            writer.WriteEndObject();
        }

        internal static RoundTripOnNoUse DeserializeRoundTripOnNoUse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<CollectionItem> requiredCollection = default;
            string baseModelProp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requiredCollection"u8))
                {
                    List<CollectionItem> array = new List<CollectionItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CollectionItem.DeserializeCollectionItem(item));
                    }
                    requiredCollection = array;
                    continue;
                }
                if (property.NameEquals("baseModelProp"u8))
                {
                    baseModelProp = property.Value.GetString();
                    continue;
                }
            }
            return new RoundTripOnNoUse(baseModelProp, requiredCollection);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RoundTripOnNoUse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRoundTripOnNoUse(document.RootElement);
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
