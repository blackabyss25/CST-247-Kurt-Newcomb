using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2_Part1.Models
{
    public class ButtonModel
    {
        public bool State{ get; set; }

        public ButtonModel(bool state)
        {
            this.State = state;
        }
    }
}