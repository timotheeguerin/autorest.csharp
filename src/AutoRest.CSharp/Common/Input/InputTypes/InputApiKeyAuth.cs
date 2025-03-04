﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace AutoRest.CSharp.Common.Input;

internal record InputApiKeyAuth(string Name)
{
    public InputApiKeyAuth() : this(string.Empty) { }
}
