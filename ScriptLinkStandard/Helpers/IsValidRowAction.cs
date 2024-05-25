
// Abatab v23.7.0.0
// A custom web service/framework for myAvatar.
// https://github.com/spectrum-health-systems/Abatab
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.


using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether a supplied RowAction value is valid.
        /// </summary>
        /// <param name="rowAction"></param>
        /// <returns></returns>
        public static bool IsValidRowAction(string rowAction)
        {
            if (rowAction == RowAction.Add ||
                rowAction == RowAction.Delete ||
                rowAction == RowAction.Edit ||
                rowAction == RowAction.None)
                return true;
            return false;
        }
    }
}
