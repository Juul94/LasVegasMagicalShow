using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LasVegasMagicalShow
{
    public class Magician : Person
    {
        private ArrayList magicianFavTricks;
        private string favTricks;

        public Magician(string personName, string personPassword) : base(personName, personPassword)
        {
            magicianFavTricks = new ArrayList();
            title = "Magician";
        }

        public Magician(string personName, string personPassword, string favTricks) : base(personName, personPassword)
        {
            magicianFavTricks = new ArrayList();
            magicianFavTricks.Add(favTricks);
            title = "Magician";
        }

        public string FavTricks
        {
            get { return favTricks; }
            set { favTricks = value; }
        }

        public void AddFavouriteTrick(string trick)
        {
            magicianFavTricks.Add(trick);
        }

        public string getTricks()
        {
            string output = "";

            for (int i = 0; i < magicianFavTricks.Count; i++)
            {
                if (i > 0)
                {
                    output = output + magicianFavTricks[i] + ", ";
                }

                else
                {
                    output = output + magicianFavTricks[i] + ", ";
                }
            }

            return output;
        }

        public override string ToString()
        {

            if (magicianFavTricks.Count > 0)
            {
                return base.ToString() + " - Tricks: " + getTricks(); 
            }

            else
            {
                return base.ToString();
            }
        }
    }
}