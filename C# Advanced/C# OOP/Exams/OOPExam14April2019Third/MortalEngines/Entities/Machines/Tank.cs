namespace MortalEngines.Entities.Machines
{
    using System.Text;

    using MortalEngines.Entities.Contracts;

    public class Tank : BaseMachine, ITank
    {
        private const double InitialHealthPoints = 100;
        private const int ModifyAttackPoints = 40;
        private const int ModifyDefensePoints = 30;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode == false)
            {
                this.DefenseMode = true;

                this.AttackPoints -= ModifyAttackPoints;
                this.DefensePoints += ModifyDefensePoints;
            }
            else
            {
                this.DefenseMode = false;

                this.AttackPoints += ModifyAttackPoints;
                this.DefensePoints -= ModifyDefensePoints;
            }
        }

        public override string ToString()
        {
            string resultDefenseMode = this.DefenseMode == true
                ? "ON"
                : "OFF";

            StringBuilder builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                   .AppendLine($" *Defense: {resultDefenseMode}");

            return builder.ToString().TrimEnd();
        }
    }
}