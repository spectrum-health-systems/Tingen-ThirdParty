
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
        /// Used to parse the received parameter.
        /// </summary>
        /// <param name="delimitedParameter"></param>
        /// <returns></returns>
        public static string[] SplitDelimitedParameter(string delimitedParameter)
        {
            string[] splitString = SplitDelimitedParameter(delimitedParameter, ',');
            return splitString;
        }
        /// <summary>
        /// Used to parse the received parameter based on provided delimiter.
        /// </summary>
        /// <param name="delimitedParameter"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string[] SplitDelimitedParameter(string delimitedParameter, char delimiter)
        {
            string[] splitString = delimitedParameter.Split(delimiter);
            return splitString;
        }
    }
}
