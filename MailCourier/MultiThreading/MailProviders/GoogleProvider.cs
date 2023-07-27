﻿using MultiThreading.MailProviders.Base;
using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.MailProviders
{
    public class GoogleProvider : BaseProvider
    {
        public override async Task Send(MailObject mailObject)
        {
            await Task.Delay(3000);
            LogManager.Default.Log($"GoogleMail has sent to --> {mailObject.To}");
        }
    }
}
