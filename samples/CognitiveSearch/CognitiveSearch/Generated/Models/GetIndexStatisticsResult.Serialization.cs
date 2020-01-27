// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class GetIndexStatisticsResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DocumentCount != null)
            {
                writer.WritePropertyName("documentCount");
                writer.WriteNumberValue(DocumentCount.Value);
            }
            if (StorageSize != null)
            {
                writer.WritePropertyName("storageSize");
                writer.WriteNumberValue(StorageSize.Value);
            }
            writer.WriteEndObject();
        }
        internal static GetIndexStatisticsResult DeserializeGetIndexStatisticsResult(JsonElement element)
        {
            GetIndexStatisticsResult result = new GetIndexStatisticsResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DocumentCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.StorageSize = property.Value.GetInt64();
                    continue;
                }
            }
            return result;
        }
    }
}
