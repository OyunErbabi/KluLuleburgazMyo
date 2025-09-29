using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_7
{
        internal class Class1
        {

            public void pasif(bool onay, params Button[] buttons)
            {
                byte i = 0;

                if(onay == true)
                {
                    for(i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].Enabled = false;
                    }
                }
                else
                {
                    for(i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].Enabled = true;
                    }
                }

            }

        }
}
