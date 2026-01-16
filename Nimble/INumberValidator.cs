using System;
using System.Collections.Generic;
using System.Text;

namespace Nimble
{
    public interface INumberValidator
    {
        public List<int> Validate(string[] parsedInput, int upperBound, bool denyNegativeNumbers);
    }
}
