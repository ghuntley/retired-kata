using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    [ContractClass(typeof(IFizzBuzzerContracts))]
    public interface IFizzBuzzer
    {
        string Print(int number);
    }
}
