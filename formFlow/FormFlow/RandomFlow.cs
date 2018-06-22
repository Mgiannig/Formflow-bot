using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;

namespace formFlow.FormFlow
{
    [Serializable]
    public class RandomFlow
    {
        [Prompt("Hello, how can I help you?")]
        public string Question { get; set; }

        [Prompt("I'm sorry, my stalking services are not working right now")]
        public string FaceBook { get; set; }

        [Prompt("Maybe you could just ask her?")]
        public string MaybeAskHer { get; set; }


        public static IForm<RandomFlow> BuildForm()
        {
            return new FormBuilder<RandomFlow>()
                    
                    .Build();
        }
    }
}