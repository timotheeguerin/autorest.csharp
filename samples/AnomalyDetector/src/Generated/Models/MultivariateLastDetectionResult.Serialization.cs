// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace AnomalyDetector.Models
{
    public partial class MultivariateLastDetectionResult
    {
        internal static MultivariateLastDetectionResult DeserializeMultivariateLastDetectionResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<VariableState>> variableStates = default;
            Optional<IReadOnlyList<AnomalyState>> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("variableStates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VariableState> array = new List<VariableState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VariableState.DeserializeVariableState(item));
                    }
                    variableStates = array;
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AnomalyState> array = new List<AnomalyState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnomalyState.DeserializeAnomalyState(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new MultivariateLastDetectionResult(Optional.ToList(variableStates), Optional.ToList(results));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MultivariateLastDetectionResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMultivariateLastDetectionResult(document.RootElement);
        }
    }
}
