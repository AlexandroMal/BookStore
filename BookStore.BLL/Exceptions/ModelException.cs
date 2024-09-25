using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Exceptions
{
    public class ModelIsEmptyException : Exception
    {
        public ModelIsEmptyException()
            :base("Invalid model: one or several fields were empty") { }
    }
}
