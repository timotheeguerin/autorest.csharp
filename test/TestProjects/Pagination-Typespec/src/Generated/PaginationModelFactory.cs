// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pagination.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class PaginationModelFactory
    {

        /// <summary> Initializes a new instance of LedgerEntry. </summary>
        /// <param name="contents"> Contents of the ledger entry. </param>
        /// <param name="collectionId"></param>
        /// <param name="transactionId"></param>
        /// <returns> A new <see cref="Models.LedgerEntry"/> instance for mocking. </returns>
        public static LedgerEntry LedgerEntry(string contents = null, string collectionId = null, string transactionId = null)
        {
            return new LedgerEntry(contents, collectionId, transactionId);
        }

        /// <summary> Initializes a new instance of TextBlocklist. </summary>
        /// <param name="blocklistName"> Text blocklist name. Only supports the following characters: 0-9  A-Z  a-z  -  .  _  ~. </param>
        /// <param name="description"> Text blocklist description. </param>
        /// <returns> A new <see cref="Models.TextBlocklist"/> instance for mocking. </returns>
        public static TextBlocklist TextBlocklist(string blocklistName = null, string description = null)
        {
            return new TextBlocklist(blocklistName, description);
        }

        /// <summary> Initializes a new instance of TextBlockItem. </summary>
        /// <param name="blockItemId"> Block Item Id. It will be uuid. </param>
        /// <param name="description"> Block item description. </param>
        /// <param name="text"> Block item content. </param>
        /// <returns> A new <see cref="Models.TextBlockItem"/> instance for mocking. </returns>
        public static TextBlockItem TextBlockItem(string blockItemId = null, string description = null, string text = null)
        {
            return new TextBlockItem(blockItemId, description, text);
        }
    }
}
