
// Abatab v23.7.0.0
// A custom web service/framework for myAvatar.
// https://github.com/spectrum-health-systems/Abatab
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.


using System;
using ScriptLinkStandard.Interfaces;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Helpers
{
    public partial class ScriptLinkHelpers
    {
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in an <see cref="IOptionObject"/> is marked for deletion by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowMarkedForDeletion(IOptionObject optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            return IsRowMarkedForDeletion(optionObject.ToOptionObject2015(), rowId);
        }
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in an <see cref="IOptionObject2"/> is marked for deletion by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowMarkedForDeletion(IOptionObject2 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            return IsRowMarkedForDeletion(optionObject.ToOptionObject2015(), rowId);
        }
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in an <see cref="IOptionObject2015"/> is marked for deletion by RowId.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowMarkedForDeletion(IOptionObject2015 optionObject, string rowId)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (optionObject.Forms == null || optionObject.Forms.Count == 0)
                throw new NullReferenceException("The OptionObject does not contain any FormObjects.");
            foreach (FormObject formObject in optionObject.Forms)
            {
                if (IsRowMarkedForDeletion(formObject, rowId))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Returns whether the <see cref="IRowObject"/> in an <see cref="IFormObject"/> is marked for deletion by RowId.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <returns></returns>
        public static bool IsRowMarkedForDeletion(IFormObject formObject, string rowId)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "formObject");
            if (rowId == null || rowId == "")
                throw new ArgumentNullException("Parameter cannot be null or blank.", "rowId");
            if (formObject.CurrentRow == null)
                throw new NullReferenceException("The FormObject does not contain a CurrentRow.");
            if (formObject.CurrentRow.RowId == rowId)
                return formObject.CurrentRow.RowAction == RowAction.Delete;
            if (formObject.MultipleIteration)
                return formObject.OtherRows.Exists(r => r.RowId == rowId && r.RowAction == RowAction.Delete);
            return false;
        }
    }
}
