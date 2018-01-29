/*
 * Copyright © The DevOps Collective, Inc. All rights reserved.
 * Licensed under GNU GPL v3. See top-level LICENSE.txt for more details.
 */

using System.Collections.Generic;

namespace TugDSC.Ext
{
    public interface IProvider<TProd>
        where TProd : IProviderProduct
    {
        ProviderInfo Describe();

        IEnumerable<ProviderParameterInfo> DescribeParameters();

        void SetParameters(IDictionary<string, object> productParams);

        TProd Produce();
    }
}