﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GGL.IO
{
    unsafe struct Token
    {
        public int line;
        public TokenKind kind;
        public string value;
    }
}
