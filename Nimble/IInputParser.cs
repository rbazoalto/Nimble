using System;
using System.Collections.Generic;
using System.Text;

namespace Nimble
{
    public interface IInputParser
    {
        public string[] Parse(string input);
    }
}
