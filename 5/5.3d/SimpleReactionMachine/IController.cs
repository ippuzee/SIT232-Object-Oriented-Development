using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReactionMachine
{
    internal interface IController
    {
        //Connect controller to gui
        //(This method will be called before any other methods)
        void Connect(IGui gui, IRandom rng);

        //Called to initialise the controller
        void Init();

        //Called whenever a coin is inserted into the machine
        void CoinInserted();

        //Called whenever the go/stop button is pressed
        void GoStopPressed();

        //Called to deliver a TICK to the controller
        void Tick();
    }
}
