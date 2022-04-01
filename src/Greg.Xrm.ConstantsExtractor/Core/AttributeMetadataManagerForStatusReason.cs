﻿using System;
using System.Collections.Generic;

namespace Greg.Xrm.ConstantsExtractor.Core
{
	public class AttributeMetadataManagerForStatusReason : AttributeMetadataManager
    {
        public AttributeMetadataManagerForStatusReason(
            string entityLogicalName,
            string displayName,
            string logicalname,
            string type,
            string description,
            List<Tuple<int, int, string>> statusvalues)
          : base(entityLogicalName, displayName, logicalname, type, description)
        {
            this.StatusReasonValues = statusvalues ?? new List<Tuple<int, int, string>>();
        }

        public List<Tuple<int, int, string>> StatusReasonValues { get; set; }

		public override void WriteFieldInfo(List<string> fileRows)
        {
            fileRows.Add("\t\t/// Values:");
            foreach (var statusReasonValue in this.StatusReasonValues)
                fileRows.Add($"\t\t/// {statusReasonValue.Item3}: {statusReasonValue.Item2},");
        }
	}
}
