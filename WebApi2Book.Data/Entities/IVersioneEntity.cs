﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Book.Data.Entities
{
    public interface IVersioneEntity
    {
        byte[] Version { get; set; }
    }
}
