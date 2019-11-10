using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
//using System.Web.Mvc;
//using Twilio.Mvc;
//using Twilio.TwiML;
//using Twilio.TwiML.Mvc;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            string bodyString = Console.ReadLine();

            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            
                const string accountSid = "AC9630b339e1753f1793027810038444c2";
                const string authToken = "b9ee35a4db8517b67ec150fda897d230";

                TwilioClient.Init(accountSid, authToken);
                
                var message = MessageResource.Create(
                    body: bodyString,
                    from: new Twilio.Types.PhoneNumber("+12029153131"), 
                    to: new Twilio.Types.PhoneNumber("+19132386683")
                );
            
                Console.WriteLine(message.Sid); 
        }
    }

    
}
