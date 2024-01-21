using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(cutomerMetaData))]
    public partial class customer
    {
        public class cutomerMetaData
        {
            [DisplayName("Customer Id")]
            public int id { get; set; }

            [DisplayName("Customer Name")]
            public string custname { get; set; }

            [DisplayName("Address")]
            public string address { get; set; }

            [DisplayName("Mobile Number")]
            public Nullable<int> mobile { get; set; }
        }
    }
}