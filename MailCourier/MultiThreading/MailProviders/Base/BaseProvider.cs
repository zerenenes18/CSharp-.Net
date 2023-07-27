using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.MailProviders.Base
{
    public abstract class BaseProvider
    {
        public int Port { get; set; }
        public string ServerHostName { get; set; } = "smtp.google.com";

        public abstract Task Send(MailObject mailObject);

    }
}
