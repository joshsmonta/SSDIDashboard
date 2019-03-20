using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SonicData.Model
{
    public class RequisitionRequest
    {
        [Key]
        public int RequestId { get; set; }
        public string ReqPosition { get; set; }
        public string PosDept { get; set; }
        public string PosDiv { get; set; }
        public int Quantity { get; set; }
        public string PersonToReplace { get; set; }
        public string ReasonForReplacment { get; set; }
        public bool Temporary { get; set; }
        public int DurationInYears { get; set; }
        public int DurationInMonths { get; set; }
        public string RequestedBy { get; set; }
        public string ReviewedBy { get; set; }
        public string ApprovedBy { get; set; }
    }
}
