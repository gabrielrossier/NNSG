﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Needs
{
    abstract class Need : ITick
    {
        public float level;
        public Person person;
        public string name;

        public void Ticking()
        {
            throw new NotImplementedException();
        }
    }
}