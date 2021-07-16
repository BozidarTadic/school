using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Inside.Common
{
    public interface IResponse<T>
    {
        HttpStatusCode StatusCode { get; set; }
        T Content { get; set; }
        List<ErrorResult> ErrorMessage { get; set; }
    }
}
