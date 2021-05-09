using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myAssistantDevAPI;

namespace App_Template
{
    public class App : app
    {
        /*
         * the method that is called when the app is loaded it must retern this; 
         */

        public override app LoadApp()
        {
            /*
             * this method adds the OnWordDectectedEvent hi to this app
             * the frest arg is the OnWordDectectedEvent that is regester
             * the second arg is the Keyword it will be called on
            */

            RegesterOnWordDectectedEvent(new hi(), "hello world");

            /*
             * this returns the app to MyAssistant affter all events are regeterd and is similar to the main method in a standard program
             */

            return this;
        }

        /*
         * a class that extends the class onWordDectectedEvent from the myAssistantDevAPI
         */

        class hi : onWordDectectedEvent
        {
            /*
             * the method from the MyAssistantDevAPI that is called when the event is detected
             * the arg reslat is the string that was trigger the event
             */

            public override void onWordDectected(String result)
            {
                /*
                 * Say.say is a utilty method that speckes a string or int
                 * the frst arg is the String / int that is spockan
                 * TESTING TESTING 123
                 */

                Say.say("hello user");
            }
        }
    }
}
