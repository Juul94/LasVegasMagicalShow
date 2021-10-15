using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LasVegasMagicalShow
{
    // Abstract class
    public abstract class Person
    {
        // Class Variable
        private static int idCount = 1;
        protected string title;

        // Instance Variable
        protected int personId;
        protected string personName;
        protected string personPassword;

        // Constructor
        public Person(string personName, string personPassword)
        {
            this.personName = personName;
            this.personPassword = personPassword;
            title = "";

            personId = idCount;
            idCount++;
        }

        // Properties
        public string PersonName { get { return personName; } set { personName = value; } }

        public string PersonPassword { get { return personPassword; } set { personPassword = value; } }

        public string Title { get { return title; } set { title = value; } }

        // ToString
        public override string ToString()
        {
            return "(" + personId + ") " + personName + " (" + title + ") Password: " + personPassword;
        }
    }
}