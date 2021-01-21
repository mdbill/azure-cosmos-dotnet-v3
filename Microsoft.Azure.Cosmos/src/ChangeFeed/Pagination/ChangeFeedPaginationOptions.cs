﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.ChangeFeed.Pagination
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using Microsoft.Azure.Cosmos.Json;
    using Microsoft.Azure.Cosmos.Pagination;

    internal sealed class ChangeFeedPaginationOptions : PaginationOptions
    {
        public static readonly ChangeFeedPaginationOptions Default = new ChangeFeedPaginationOptions(
            mode: ChangeFeedMode.Incremental);

        public ChangeFeedPaginationOptions(
            ChangeFeedMode mode,
            int? pageSizeHint = null,
            JsonSerializationFormat? jsonSerializationFormat = null,
            Dictionary<string, string> additionalHeaders = null)
            : base(pageSizeHint, jsonSerializationFormat, additionalHeaders)
        {
            this.Mode = mode ?? throw new ArgumentNullException(nameof(mode));
        }

        public ChangeFeedMode Mode { get; }

        protected override ImmutableHashSet<string> BannedAdditionalHeaders => throw new System.NotImplementedException();
    }
}
