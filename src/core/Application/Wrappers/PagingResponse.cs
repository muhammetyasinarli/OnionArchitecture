﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrappers
{
    public class PagingResponse<T> : ServiceResponse<T>
    {

        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public PagingResponse(T value, int pageSize, int pageNumber) : base(value)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }
}
