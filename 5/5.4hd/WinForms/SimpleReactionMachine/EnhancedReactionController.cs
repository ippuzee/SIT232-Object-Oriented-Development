using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReactionMachine
{
    internal class EnhancedReactionController
    {
        // Settings for the game times
        private const int MAX_READY_TIME = 1000; // Maximum time in ready without pressing GoStop
        private const int MIN_WAIT_TIME = 100;   // Minimum wait time, 1 sec in ticks
        private const int MAX_WAIT_TIME = 250;   // Maximum wait time, 2.5 sec in ticks
        private const int MAX_GAME_TIME = 200;   // Maximum of 2 sec to react, in ticks
        private const int GAMEOVER_TIME = 300;   // Display result for 3 sec, in ticks
        private const int RESULTS_TIME = 500;    // Display average time for 5 sec, in ticks
        private const double TICKS_PER_SECOND = 100.0; // Based on 10ms ticks

        // Instance variables and properties
        private State _state;
        private IGui Gui { get; set; }
        private IRandom Rng { get; set; }
        private int Ticks { get; set; }
        private int Games { get; set; }
        private int TotalReactionTime { get; set; }

        
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
        public void Init() => _state = new OnState(this);

        /// Coin inserted event handler
        public void CoinInserted() => _state.CoinInserted();

        /// Go/Stop pressed event handler
        public void GoStopPressed() => _state.GoStopPressed();


        /// Tick event handler
        public void Tick() => _state.Tick();

        /// Sets the state of the controller to the desired state
        /// <param name="state">The new state to transition to</param>
        void SetState(State state) => _state = state;

        /// Base class for concrete State classes
        abstract class State
        {
            protected EnhancedReactionController controller;
            public State(EnhancedReactionController con) => controller = con;
            public abstract void CoinInserted();
            public abstract void GoStopPressed();
            public abstract void Tick();
        }

        /// State of the game when it is waiting for a coin to be inserted
        class OnState : State
        {
            public OnState(EnhancedReactionController con) : base(con)
            {
                controller.Games = 0;
                controller.TotalReactionTime = 0;
                controller.Gui.SetDisplay("Insert coin");
            }
            public override void CoinInserted() => controller.SetState(new ReadyState(controller));
            public override void GoStopPressed() { }
            public override void Tick() { }
        }

        /// State of the game when a coin has been inserted, but the game is not yet
        /// started
        class ReadyState : State
        {
            public ReadyState(EnhancedReactionController con) : base(con)
            {
                controller.Gui.SetDisplay("Press Go!");
                controller.Ticks = 0;
            }
            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                controller.SetState(new WaitState(controller));
            }
            public override void Tick()
            {
                controller.Ticks++;
                if (controller.Ticks == MAX_READY_TIME)
                    controller.SetState(new OnState(controller));
            }
        }

        /// State of the game when the game has started and it is waiting for the
        /// random time
        class WaitState : State
        {
            private int _waitTime;
            public WaitState(EnhancedReactionController con) : base(con)
            {
                controller.Gui.SetDisplay("Wait...");
                controller.Ticks = 0;
                _waitTime = controller.Rng.GetRandom(MIN_WAIT_TIME, MAX_WAIT_TIME);
            }
            public override void CoinInserted() { }
            public override void GoStopPressed() => controller.SetState(new OnState(controller));
            public override void Tick()
            {
                controller.Ticks++;
                if (controller.Ticks == _waitTime)
                {
                    controller.Games++;
                    controller.SetState(new RunningState(controller));
                }
            }
        }

        /// State of the game when the timer is counting and it is waiting for the
        /// user to react by pressing the Go/Stop button
        class RunningState : State
        {
            public RunningState(EnhancedReactionController con) : base(con)
            {
                controller.Gui.SetDisplay("0.00");
                controller.Ticks = 0;
            }
            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                controller.TotalReactionTime += controller.Ticks;
                controller.SetState(new GameOverState(controller));
            }
            public override void Tick()
            {
                controller.Ticks++;
                controller.Gui.SetDisplay(
                    (controller.Ticks / TICKS_PER_SECOND).ToString("0.00"));
                if (controller.Ticks == MAX_GAME_TIME)
                    controller.SetState(new GameOverState(controller));
            }
        }

        /// State of the game when the time has expired, or the user reacted.
        /// If 3 games not yet played, sets the state to Wait, otherwise to
        /// Results
        class GameOverState : State
        {
            public GameOverState(EnhancedReactionController con) : base(con)
            {
                controller.Ticks = 0;
            }
            public override void CoinInserted() { }
            public override void GoStopPressed() => CheckGames();
            public override void Tick()
            {
                controller.Ticks++;
                if (controller.Ticks == GAMEOVER_TIME)
                    CheckGames();
            }
            private void CheckGames()
            {
                if (controller.Games == 3)
                {
                    controller.SetState(new ResultsState(controller));
                    return;
                }
                controller.SetState(new WaitState(controller));
            }
        }

        /// Shows the average reaction time for the 3 games played, for 
        /// 5 seconds, or until GoStop is pressed
        class ResultsState : State
        {
            public ResultsState(EnhancedReactionController con) : base(con)
            {
                controller.Gui.SetDisplay("Average: "
                    + (((double)controller.TotalReactionTime / controller.Games) / TICKS_PER_SECOND)
                    .ToString("0.00"));
                controller.Ticks = 0;
            }
            public override void CoinInserted() { }
            public override void GoStopPressed() => controller.SetState(new OnState(controller));
            public override void Tick()
            {
                controller.Ticks++;
                if (controller.Ticks == RESULTS_TIME)
                    controller.SetState(new OnState(controller));
            }
        }
    }
}
