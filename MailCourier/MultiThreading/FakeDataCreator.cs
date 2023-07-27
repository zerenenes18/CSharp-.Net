﻿using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class FakeDataCreator
    {
        public static IEnumerable<MailObject> GetSmtpMails(int number)
        {
           return GetMails(number, MailProviderType.Smtp);

        }
        public static IEnumerable<MailObject> GetGoogleMails(int number)
        {
            return GetMails(number, MailProviderType.Google);

        }

        public static IEnumerable<MailObject> GetMails(int number, MailProviderType? mailProviderType = null)
        {
            Bogus.Faker<MailObject> faker = new Bogus.Faker<MailObject>()
                .RuleFor(i => i.To, y => y.Internet.Email())
                .RuleFor(i => i.ProviderType, y => !mailProviderType.HasValue
                                            ? y.PickRandom<MailProviderType>()
                                            : mailProviderType);



            return faker.Generate(number);
        }

    }
}
