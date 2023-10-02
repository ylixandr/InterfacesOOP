using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesOOP
{
    public class Worker : Person, IStudent
    {
        string name;
        public Worker(string name) : base(name)
        {
            this.name =name;
        }   
        

        public void Work()
        {
            Console.WriteLine(" Worker is working now");
        }

        void IStudent.Study()
        {
            Console.WriteLine(" Учится в институте");
        }

        void IGuitare.Play()
        {
            Console.WriteLine(" Игарем на гитаре");
        }

      

        void IBall.Play()
        {
            Console.WriteLine(" Играем в мяч");
        }

        void IStudent.Play()
        {
            Console.WriteLine(" Играем в КВН???????");
        }
    }
}
