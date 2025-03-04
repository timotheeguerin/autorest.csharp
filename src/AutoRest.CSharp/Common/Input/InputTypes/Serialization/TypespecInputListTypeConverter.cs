﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AutoRest.CSharp.Common.Input
{
    internal sealed class TypespecInputListTypeConverter : JsonConverter<InputListType>
    {
        private readonly TypespecReferenceHandler _referenceHandler;

        public TypespecInputListTypeConverter(TypespecReferenceHandler referenceHandler)
        {
            _referenceHandler = referenceHandler;
        }

        public override InputListType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.ReadReferenceAndResolve<InputListType>(_referenceHandler.CurrentResolver) ?? CreateListType(ref reader, null, null, options);

        public override void Write(Utf8JsonWriter writer, InputListType value, JsonSerializerOptions options)
            => throw new NotSupportedException("Writing not supported");

        public static InputListType CreateListType(ref Utf8JsonReader reader, string? id, string? name, JsonSerializerOptions options)
        {
            var isFirstProperty = id == null && name == null;
            InputType? elementType = null;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadString(nameof(InputListType.Name), ref name)
                    || reader.TryReadWithConverter(nameof(InputListType.ElementType), options, ref elementType);

                if (!isKnownProperty)
                {
                    reader.SkipProperty();
                }
            }

            elementType = elementType ?? throw new JsonException("List must have element type");
            return new InputListType(name ?? "List", elementType);
        }
    }
}
