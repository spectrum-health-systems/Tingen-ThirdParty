
// Abatab v23.7.0.0
// A custom web service/framework for myAvatar.
// https://github.com/spectrum-health-systems/Abatab
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.


using System;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether a string is a valid URL for use with error code 5.
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public static bool IsValidUrl(string strUrl)
        {
            return Uri.IsWellFormedUriString(strUrl, UriKind.Absolute);
        }
    }
}
