// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    internal static class IndexerExecutionStatusExtensions
    {
        public static string ToSerialString(this IndexerExecutionStatus value) => value switch
        {
            IndexerExecutionStatus.TransientFailure => "transientFailure",
            IndexerExecutionStatus.Success => "success",
            IndexerExecutionStatus.InProgress => "inProgress",
            IndexerExecutionStatus.Reset => "reset",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IndexerExecutionStatus value.")
        };

        public static IndexerExecutionStatus ToIndexerExecutionStatus(this string value) => value switch
        {
            "transientFailure" => IndexerExecutionStatus.TransientFailure,
            "success" => IndexerExecutionStatus.Success,
            "inProgress" => IndexerExecutionStatus.InProgress,
            "reset" => IndexerExecutionStatus.Reset,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IndexerExecutionStatus value.")
        };
    }
}
