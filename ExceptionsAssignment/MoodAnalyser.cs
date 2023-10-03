﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string analyse_mood()
        {
            if(this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
