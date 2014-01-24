using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalyzeCatchTool.Models
{
    [Serializable]
    public class ConfigurationEntity
    {
        public string SourceDBConnectionString { get; set; }

        public string TargetDBConnectionString { get; set; }

        public string TargetTableName { get; set; }

        public string SourceTableName { get; set; }

        public string BreakDownColumns { get; set; }

        public string SplitString { get; set; }

        public string InstertPrimaryTableTemplate { get; set; }

        public string InstertSubTableTemplate { get; set; }

        public string CheckRowInstertPrimaryTable { get; set; }
        public string CheckRowInstertSubTable { get; set; }        


    }
}
