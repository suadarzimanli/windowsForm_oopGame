using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolfAttacck.Models
{
    public class Damage
    {
        public int damage2 { get; set; }

        Random random2 = new Random();

        public void Attack2()
        {
            /*
                race => human+10, monster +20
            */

            damage2 += random2.Next(15, 51);

        }
        
    }
}
