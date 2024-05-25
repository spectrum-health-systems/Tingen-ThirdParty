﻿
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
        /// Returns the FieldValue of a specified <see cref="IFieldObject"/> in an <see cref="IOptionObject"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IOptionObject optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetFieldValue(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns the FieldValue of a specified <see cref="IFieldObject"/> in an <see cref="IOptionObject"/> by FormId, RowId, and FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IOptionObject optionObject, string formId, string rowId, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetFieldValue(optionObject.ToOptionObject2015(), formId, rowId, fieldNumber);
        }
        /// <summary>
        /// Returns the FieldValue of a specified <see cref="IFieldObject"/> in an <see cref="IOptionObject2"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IOptionObject2 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetFieldValue(optionObject.ToOptionObject2015(), fieldNumber);
        }
        /// <summary>
        /// Returns the FieldValue of a specified <see cref="IFieldObject"/> in an <see cref="IOptionObject2"/> by FormId, RowId, and FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IOptionObject2 optionObject, string formId, string rowId, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            return GetFieldValue(optionObject.ToOptionObject2015(), formId, rowId, fieldNumber);
        }
        /// <summary>
        /// Returns the FieldValue of a specified <see cref="IFieldObject"/> in an <see cref="IOptionObject2015"/> by FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IOptionObject2015 optionObject, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            foreach (var form in optionObject.Forms)
            {
                if (form.IsFieldPresent(fieldNumber))
                    return GetFieldValue(form, fieldNumber);
            }
            throw new ArgumentException("FieldObject (" + fieldNumber + ") could not be found.");
        }
        /// <summary>
        /// Returns the FieldValue of a specified <see cref="IFieldObject"/> in an <see cref="IOptionObject2015"/> by FormId, RowId, and FieldNumber.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IOptionObject2015 optionObject, string formId, string rowId, string fieldNumber)
        {
            if (optionObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "optionObject");
            foreach (var form in optionObject.Forms)
            {
                if (form.FormId == formId)
                    return GetFieldValue(form, rowId, fieldNumber);
            }
            throw new ArgumentException("FieldObject (" + fieldNumber + ") could not be found.");
        }
        /// <summary>
        /// Returns the FieldValue of a <see cref="IFieldObject"/> in a <see cref="IFormObject"/> by FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IFormObject formObject, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "formObject");
            return GetFieldValue(formObject, formObject.CurrentRow.RowId, fieldNumber);
        }
        /// <summary>
        /// Returns the FieldValue of a <see cref="IFieldObject"/> in a <see cref="IFormObject"/> by RowId and FieldNumber.
        /// </summary>
        /// <param name="formObject"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IFormObject formObject, string rowId, string fieldNumber)
        {
            if (formObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "formObject");
            if (formObject.CurrentRow.RowId == rowId)
                return GetFieldValue(formObject.CurrentRow, fieldNumber);
            foreach (RowObject rowObject in formObject.OtherRows)
            {
                if (rowObject.RowId == rowId)
                    return GetFieldValue(rowObject, fieldNumber);
            }
            throw new ArgumentException("FieldObject (" + fieldNumber + ") could not be found.");
        }
        /// <summary>
        /// Returns the FieldValue of a <see cref="IFieldObject"/> in a <see cref="IRowObject"/> by FieldNumber.
        /// </summary>
        /// <param name="rowObject"></param>
        /// <param name="fieldNumber"></param>
        /// <returns></returns>
        public static string GetFieldValue(IRowObject rowObject, string fieldNumber)
        {
            if (rowObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "rowObject");
            foreach (FieldObject field in rowObject.Fields)
            {
                if (field.FieldNumber == fieldNumber)
                    return GetFieldValue(field);
            }
            throw new ArgumentException("FieldObject (" + fieldNumber + ") could not be found.");
        }
        /// <summary>
        /// Returns the FieldValue of a <see cref="IFieldObject"/>.
        /// </summary>
        /// <param name="fieldObject"></param>
        /// <returns></returns>
        public static string GetFieldValue(IFieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentNullException("Parameter cannot be null", "fieldObject");
            return fieldObject.FieldValue;
        }
    }
}
