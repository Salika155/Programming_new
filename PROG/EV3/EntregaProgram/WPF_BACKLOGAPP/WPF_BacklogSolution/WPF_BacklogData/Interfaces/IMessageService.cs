﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BacklogData.Interfaces
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowError(string errorMessage);
    }
}
