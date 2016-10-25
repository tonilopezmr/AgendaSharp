using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSharpConsole.Model
{
    class Contact : Person
    {
        private string phone;

        public Contact(string dni, string name, string phone) : base(dni, name)
        {
            this.phone = phone;
        }

        public string GetPhone() {
            return this.phone;
        }
    }
}
