﻿using System;
using System.Collections.Generic;
using System.Text;
using DIaLOGIKa.b2xtranslator.StructuredStorage.Reader;
using DIaLOGIKa.b2xtranslator.Spreadsheet.XlsFileFormat.BiffRecords;

namespace DIaLOGIKa.b2xtranslator.Spreadsheet.XlsFileFormat
{
    public class SeriesDataSequence : BiffRecordSequence
    {
        public SeriesDataSequence(IStreamReader reader)
            : base(reader)
        {

        }
    }
}