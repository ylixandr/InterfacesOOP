using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesOOP
{
    public interface IStudent:IGuitare,IBall
    {
        public void Study();

        public new void Play();
    }
}
