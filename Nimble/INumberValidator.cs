using System.Collections.Generic;

namespace Nimble
{
    public interface INumberValidator
    {
        public List<int> Validate(string[] parsedInput, int upperBound, bool denyNegativeNumbers);
    }
}
