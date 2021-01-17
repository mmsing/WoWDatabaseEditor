﻿using System.Collections.Generic;
using WDE.Common.Parameters;
using WDE.Module.Attributes;

namespace WDE.Common.Providers
{
    [UniqueProvider]
    public interface IItemFromListProvider
    {
        int? GetItemFromList(Dictionary<int, SelectOption> items, bool flag);
    }
}