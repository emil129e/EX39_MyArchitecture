using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter01
{
    public class CustomArgs : EventArgs
    {
		//implement as described in the class diagram
		
        public CustomArgs(string before, string after)
        {
            MessageAfter = after;
            MessageBefore = before;

            //to be implemented
        }

        public string MessageAfter { get; internal set; }
        public string MessageBefore { get; internal set; }
    }
}
