using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    [ContractClassFor(typeof(IFizzBuzzer))]
    public abstract class IFizzBuzzerContracts : IFizzBuzzer
    {
        public string Print(int number)
        {
            Contract.Requires(number >= 1 & number <= 100);

            throw new NotImplementedException();
        }
    }
}
