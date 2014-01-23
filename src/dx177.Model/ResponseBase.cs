using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model
{
    [Serializable]
    public class ResponseBase
    {
        public bool Status { get; set; }

        public string ErrorMessage { get; set; }
    }
}
