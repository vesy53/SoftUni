namespace MortalEngines.Entities.Machines
{
    using System.Text;

    using MortalEngines.Entities.Contracts;

    public class Fighter : BaseMachine, IFighter
    {
        private const double InitialHealthPoints = 200;
        private const int ModifyAttackPoints = 50;
        private const int ModifyDefensePoints = 25;

        public Fighter(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleAggressiveMode();
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (this.AggressiveMode == false)
            {
                this.AggressiveMode = true;

                this.AttackPoints += ModifyAttackPoints;
                this.DefensePoints -= ModifyDefensePoints;
            }
            else if (this.AggressiveMode == true)
            {
                this.AggressiveMode = false;

                this.AttackPoints -= ModifyAttackPoints;
                this.DefensePoints += ModifyDefensePoints;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            string resultAggressiveMode = this.AggressiveMode == true
                ? "ON"
                : "OFF";

            builder.AppendLine(base.ToString())
                   .AppendLine($" *Aggressive: {resultAggressiveMode}");

            return builder.ToString().TrimEnd();
        }
    }
}
