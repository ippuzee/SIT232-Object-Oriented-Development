using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReactionMachine
{
    internal class SimpleReactioController : IController
    {
        // Settings for the game times
        private const int MIN_WAIT_TIME = 100; // Minimum wait time, 1 sec in ticks
        private const int MAX_WAIT_TIME = 250; // Maximum wait time, 2.5 sec in ticks
        private const int MAX_GAME_TIME = 200; // Maximum of 2 sec to react, in ticks
        private const int GAMEOVER_TIME = 300; // Display result for 3 sec, in ticks
        private const double TICKS_PER_SECOND = 100.0; // Based on 10ms ticks

        // Instance variables and properties
        private State _state;
        private IGui Gui { get; set; }
        private IRandom Rng { get; set; }
        private int Ticks { get; set; }

        
        /// Connects the controller to the Gui and Random Number Generator
        
        /// <param name="gui">IGui concrete implementation</param>
        /// <param name="rng">IRandom concreate implementation</param>
        public void Connect(IGui gui, IRandom rng)
        {
            Gui = gui;
            Rng = rng;
            Init();
        }

        
        /// Initialises the state of the controller at the start of the program
        public void Init()
        {
            _state = new OnState(this);
        }

        
        /// Coin inserted event handler
        public void CoinInserted()
        {
            _state.CoinInserted();
        }

        
        /// Go/Stop pressed event handler
        public void GoStopPressed()
        {
            _state.GoStopPressed();
        }

        
        /// Tick event handler
        public void Tick()
        {
            _state.Tick();
        }

        /// Sets the state of the controller to the desired state

        /// <param name="state">The new state to transition to</param>
        private void SetState(State state)
        {
            _state = state;
        }

        
        /// Base class for concrete State classes
        private abstract class State
        {
            protected SimpleReactioController _controller;

            public State(SimpleReactioController controller)
            {
                _controller = controller;
            }

            public abstract void CoinInserted();
            public abstract void GoStopPressed();
            public abstract void Tick();
        }

        
        /// State of the game when it is waiting for a coin to be inserted
        private class OnState : State
        {
            public OnState(SimpleReactioController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("Insert coin");
            }

            public override void CoinInserted()
            {
                _controller.SetState(new ReadyState(_controller));
            }
            public override void GoStopPressed() { }
            public override void Tick() { }
        }

        
        /// State of the game when a coin has been inserted, but the game is not yet
        /// started
        private class ReadyState : State
        {
            public ReadyState(SimpleReactioController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("Press Go!");
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new WaitState(_controller));
            }
            public override void Tick() { }
        }

        /// State of the game when the game has started and it is waiting for the
        /// random 
        private class WaitState : State
        {
            private int _waitTime;
            public WaitState(SimpleReactioController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("Wait...");
                _controller.Ticks = 0;
                _waitTime = _controller.Rng.GetRandom(MIN_WAIT_TIME, MAX_WAIT_TIME);
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new OnState(_controller));
            }
            public override void Tick()
            {
                _controller.Ticks++;
                if (_controller.Ticks == _waitTime)
                {
                    _controller.SetState(new RunningState(_controller));
                }
            }
        }

        /// State of the game when the timer is counting and it is waiting for the
        /// user to react by pressing the Go/Stop button
        private class RunningState : State
        {
            public RunningState(SimpleReactioController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("0.00");
                _controller.Ticks = 0;
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new GameOverState(_controller));
            }

            public override void Tick()
            {
                _controller.Ticks++;
                _controller.Gui.SetDisplay(
                    (_controller.Ticks / TICKS_PER_SECOND).ToString("0.00"));
                if (_controller.Ticks == MAX_GAME_TIME)
                {
                    _controller.SetState(new GameOverState(_controller));
                }
            }
        }

        /// State of the game when the time has expired, or the user reacted.
        private class GameOverState : State
        {
            public GameOverState(SimpleReactioController controller) : base(controller)
            {
                _controller.Ticks = 0;
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new OnState(_controller));
            }
            public override void Tick()
            {
                _controller.Ticks++;
                if (_controller.Ticks == GAMEOVER_TIME)
                {
                    _controller.SetState(new OnState(_controller));
                }
            }
        }
    }
}
