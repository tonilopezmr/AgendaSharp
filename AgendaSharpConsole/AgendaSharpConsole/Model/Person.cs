using System;

namespace AgendaSharpConsole.Model {

    class Person
    {
        private string dni;
        private string name;

        public Person(string dni, string name)
        {
            this.dni = dni;
            this.name = name;
        }

        public string GetDni()
        {
            return this.dni;
        }

        public string GetName()
        {
            return this.name;
        }

    }

}
