using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolfAttacck.Models
{
    public class Account
    {
        public string userName { get; set; }
        public string race { get; set; }
        public string branch { get; set; }
        public string weapon { get; set; }
        public int damage { get; set; }

        Random random = new Random();

        public void Attack()
        {
            /*
                race => human+10, monster +20
                warrior => 40
                mage => 30 - 50
                wizard => 10 - 70
                archer => 5 or 60 
                
            */

            if (race == "human")
            {
                damage += 10;
            }
            else
            {
                damage += 20;
            }
            switch (branch)
            {
                case "warrior":
                    damage += 40;
                    break;
                case "mage":
                    damage += random.Next(30, 51);
                    break;
                case "wizard":
                    damage += random.Next(10, 71);
                    break;
                case "archer":
                    int number = random.Next(0, 2); // random can be o to 1 
                    damage += number == 0 ? 5 : 60; // ? is number == 0 then damage is 5  : if it is not, if number==1 then damage is  60
                    break;

            }
        }

    }
}
