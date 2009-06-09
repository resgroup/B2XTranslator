﻿using System;
using System.Collections.Generic;
using System.Text;
using DIaLOGIKa.b2xtranslator.Spreadsheet.XlsFileFormat;
using DIaLOGIKa.b2xtranslator.CommonTranslatorLib;
using DIaLOGIKa.b2xtranslator.OpenXmlLib.DrawingML;

namespace DIaLOGIKa.b2xtranslator.SpreadsheetMLMapping
{
    public class DataPointMapping : AbstractChartMapping,
          IMapping<SsSequence>
    {
        int _index;

        public DataPointMapping(ExcelContext workbookContext, ChartContext chartContext, int index)
            : base(workbookContext, chartContext)
        {
            _index = index;
        }

        public void Apply(SsSequence ssSequence)
        {
            // c:dPt
            _writer.WriteStartElement(Dml.Chart.Prefix, "dPt", Dml.Chart.Ns);
            {
                // c:bubble3D

                // c:explosion

                // c:idx
                writeValueElement("idx", _index.ToString());

                // c:invertIfNegative

                // c:marker

                // c:pictureOptions

                // c:spPr
                _writer.WriteStartElement(Dml.Chart.Prefix, "spPr", Dml.Chart.Ns);
                {
                    if (ssSequence.AreaFormat1 != null)
                    {
                        ssSequence.AreaFormat1.Convert(new AreaFormatMapping(this.WorkbookContext, this.ChartContext, ssSequence.GelFrameSequence));
                    }

                    if(ssSequence.LineFormat1 != null)
                    {
                        ssSequence.LineFormat1.Convert(new LineFormatMapping(this.WorkbookContext, this.ChartContext));
                    }
                }
                _writer.WriteEndElement();
            }
            _writer.WriteEndElement();
        }
    }
}