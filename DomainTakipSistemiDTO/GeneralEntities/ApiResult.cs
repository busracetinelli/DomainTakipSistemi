using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainTakipSistemiDTO.GeneralEntities
{
    public class ApiResult
    {
      
            public bool Result { get; set; }
            public object Data { get; set; }
            public string Message { get; set; }
        }

    }
}