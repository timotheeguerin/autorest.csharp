// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable enable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Core
{
    internal static class RequestContentHelper
    {
        public static RequestContent FromDictionary<T>(IDictionary<string, T> dictionary) where T : notnull
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartObject();
            foreach (var item in dictionary)
            {
                content.JsonWriter.WritePropertyName(item.Key);
                content.JsonWriter.WriteObjectValue(item.Value);
            }
            content.JsonWriter.WriteEndObject();

            return content;
        }

        public static RequestContent FromDictionary(IDictionary<string, BinaryData> dictionary)
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartObject();
            foreach (var item in dictionary)
            {
                content.JsonWriter.WritePropertyName(item.Key);

                if (item.Value == null)
                {
                    content.JsonWriter.WriteNullValue();
                }
                else
                {
#if NET6_0_OR_GREATER
                    content.JsonWriter.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(content.JsonWriter, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
            }
            content.JsonWriter.WriteEndObject();

            return content;
        }
    }
}
