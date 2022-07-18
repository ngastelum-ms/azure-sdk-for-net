// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The response to a list database metrics request. </summary>
    internal partial class SqlMetricListResult
    {
        /// <summary> Initializes a new instance of SqlMetricListResult. </summary>
        /// <param name="value"> The list of metrics for the database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SqlMetricListResult(IEnumerable<SqlMetric> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SqlMetricListResult. </summary>
        /// <param name="value"> The list of metrics for the database. </param>
        internal SqlMetricListResult(IReadOnlyList<SqlMetric> value)
        {
            Value = value;
        }

        /// <summary> The list of metrics for the database. </summary>
        public IReadOnlyList<SqlMetric> Value { get; }
    }
}
