using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Models
{
    public class GeneralRmBmDetail
    {
        [Key]
        public virtual int ROW_ID { get; set; }
        public virtual int BRANCH_CODE { get; set; }
        public virtual string BRANCH_NAME { get; set; }
        public virtual string REGION { get; set; }
        public virtual int EPF { get; set; }
        public virtual string STATUS { get; set; }
        public virtual string NAME { get; set; }
        public virtual string FULL_NAME { get; set; }
        public virtual string MOBILE { get; set; }
        public virtual string TYP { get; set; }
    }
}