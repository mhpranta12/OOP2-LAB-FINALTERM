﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task3
{
    interface RadioPlayerInterface
    {

        void RSwitch(bool on);
        void retune(double frequency);
        void RsetVolume(int loudness);
        void changeChannel();
    }
}