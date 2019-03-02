using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachmannSolutions.TowerDefense
{
    class BachmannSolutionsDefenseException : System.Exception
    {
        public BachmannSolutionsDefenseException()
        {
        }

        public BachmannSolutionsDefenseException(string message) : base(message)
        {
        }
    }

    class OutOfBoundsException : BachmannSolutionsDefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }

}
