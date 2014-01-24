using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AnalyzeCatchTool
{
    public partial class 微薄评论接口模板
    {
        public DataRow Data { get; set; }

        public 微薄评论接口模板(DataRow dt)
        {
            Data = dt;
        }
    }
}
