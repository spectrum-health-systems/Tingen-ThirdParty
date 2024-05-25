
// Abatab v23.7.0.0
// A custom web service/framework for myAvatar.
// https://github.com/spectrum-health-systems/Abatab
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.


namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Safely converts a string to an integer.
        /// </summary>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public static int SafeGetInt(string fieldValue)
        {
            int tempValue = 0;
            if (int.TryParse(fieldValue, out _))
                tempValue = int.Parse(fieldValue);
            return tempValue;
        }
    }
}
