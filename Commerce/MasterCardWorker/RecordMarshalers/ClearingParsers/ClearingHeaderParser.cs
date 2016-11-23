//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//
namespace Lomo.Commerce.MasterCardWorker
{
    using System;
    using Lomo.Commerce.Logging;
    using Lomo.Commerce.MasterCardClient;
    using Lomo.Commerce.WorkerCommon;

    /// <summary>
    /// Parses a MasterCard Clearing header record.
    /// </summary>
    public class ClearingHeaderParser
    {
        /// <summary>
        /// Initializes a new instance of the ClearingHeaderParser class.
        /// </summary>
        /// <param name="log">
        /// The CommerceLog object through which log entries can be made.
        /// </param>
        public ClearingHeaderParser(CommerceLog log)
        {
            Log = log;
        }
        
        /// <summary>
        /// Parses the specified record text into a clearing header if possible.
        /// </summary>
        /// <param name="record">
        /// The record text to parse into a clearing header.
        /// </param>
        /// <returns>
        /// * The ClearingHeader object if successful.
        /// * Else returns null.
        /// </returns>
        internal ClearingHeader Parse(string record)
        {
            ClearingHeader result = new ClearingHeader();

            int recordPos = 0;
            bool recordValid = true;
            string stringField = null;
            DateTime dateField = DateTime.MinValue;

            ParsingUtilities parsingUtilities = new ParsingUtilities("Clearing File Header", 1, FileName, ClearingConstants.TimeFieldLength, Log);

            // RecordType
            recordValid = parsingUtilities.VerifyString(record, ref recordPos, "Record Type", RecordType,
                                                        ClearingConstants.RecordTypeLength, recordValid);

            // RecordDate and RecordTime
            recordValid = parsingUtilities.PopulateDateTime(record, ref recordPos, "Record Date and Time", out dateField, true, false, recordValid);
            result.CreationDate = dateField;

            // MemberIca
            recordValid = parsingUtilities.PopulateString(record, ref recordPos, out stringField, ClearingConstants.MemberIcaLength, recordValid);
            result.MemberIca = stringField;

            // Record end
            parsingUtilities.VerifyRecordEnd(record, ref recordPos, FillerLength, false, recordValid);

            // If the record is not valid, return a null value.
            if (recordValid == false)
            {
                result = null;
            }

            return result;
        }

        /// <summary>
        /// Gets or sets the name of the file being parsed.
        /// </summary>
        internal string FileName { get; set; }

        /// <summary>
        /// The record type for clearing headers.
        /// </summary>
        internal const string RecordType = "H";

        /// <summary>
        /// Gets or sets the CommerceLog object through which log entries can be made.
        /// </summary>
        private CommerceLog Log { get; set; }

        /// <summary>
        /// The number of spaces that must appear at the end of an clearing header.
        /// </summary>
        private const int FillerLength = 174;
    }
}