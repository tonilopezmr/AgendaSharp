using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSharpConsole.Model
{
    class Agenda
    {

        List<Contact> contacts;

        public Agenda() {
            this.contacts = new List<Contact>();
        }

        public void AddContact(Contact contact) {
            contacts.Add(contact);
        }

        public List<Contact> GetContacts() {
            return this.contacts;
        }
    }

}
