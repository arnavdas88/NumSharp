﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NumSharp.Core
{
    public partial class NDArray
    {
        public int sum(NDArray np2)
        {
            int result = 0;
            for (int i = 0; i < Size; i++)
            {
                if (this[i].Equals(np2[i]))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
