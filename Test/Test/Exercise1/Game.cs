using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise1
{
    public class Game
    {
        public IState currentState { get; private set; }
        public int stage { get; private set; }
        public int ShipCollisionPoints { get; private set; }

        public Game()
        {
            currentState = new NewGame();
            currentState.State();
            stage = 1;
            ShipCollisionPoints = 50;
        }

        public void Hit()
        {
            ShipCollisionPoints--;
            if(ShipCollisionPoints <= 0)
            {
                currentState = new GameEndedLost();
            }
            else if(ShipCollisionPoints <= 10)
            {
                currentState = new ShipAtRisk();
            }
            else
            {
                currentState = new ShipOK();
            }

            currentState.State();
        }

        public void NextStage()
        {
            stage++;
            if(stage >= 4)
            {
                currentState = new GameEndedWin();
            }
            else
            {
                currentState = new ShipOK();
            }
            currentState.State();

        }
    }
}
