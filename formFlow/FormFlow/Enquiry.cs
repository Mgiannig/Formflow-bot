using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.FormFlow;

namespace formFlow.FormFlow
{
    [Serializable]
    public class Enquiry
    {
        [Prompt("What's your name?")]
        public string Name { get; set; }

        [Prompt("Can I ask for which company do you work for?")] 
        public string Company { get; set; }

        [Prompt("What's your job title there?")]
        public string JobTitle { get; set; }

        [Prompt("What's the best number to contact you on?")]
        public string Phone { get; set; }

        [Prompt("Can you think of anything else that would help us understand your needs?")]
        public string HowCanWeHelp { get; set; }

        [Prompt("We send out email correspondence occasionally. Would you like to receive offers and promotions from us?")]
        public bool SingMeupToTheMailingList { get; set; }

        [Prompt("Do you know which serice you require from us? {||}")]
        public Service ServiceRequired { get; set; }

        public enum Service
        {
           Consultancy, Support, ProjectDelivery, Other
        }

        public static IForm<Enquiry> BuildEnquiryForm()
        {
            return new FormBuilder<Enquiry>()
                
                .Field("ServiceRequired")
                .Field("SingMeupToTheMailingList")
                .AddRemainingFields()

                .Build();
        }
    }
}