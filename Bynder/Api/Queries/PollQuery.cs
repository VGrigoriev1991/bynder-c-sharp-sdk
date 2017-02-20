﻿// Copyright (c) Bynder. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Bynder.Api.Converters;

namespace Bynder.Api.Queries
{
    /// <summary>
    /// Class to pass information to poll if asset has finished converting. This
    /// class should only be used by upload
    /// </summary>
    internal class PollQuery
    {
        /// <summary>
        /// Items we want to query the status.
        /// </summary>
        [APIField("items", Converter = typeof(ListConverter))]
        public IList<string> Items { get; set; } = new List<string>();
    }
}
