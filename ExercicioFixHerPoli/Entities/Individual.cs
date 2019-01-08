namespace ExercicioFixHerPoli.Entities
{
    class Individual : Payer
    {
        public double HealthExpend { get; set; }

        public Individual(string name, double anualIncome, double healthExpend) : base(name,anualIncome)
        {
            HealthExpend = healthExpend;
        }

        public override double Taxes()
        {
            double tax;
            double health = 0;

            if (AnualIncome < 20000)
            {
                tax = AnualIncome * 15 / 100;
            }
            else
            {
                tax = AnualIncome * 25 / 100;
            }

            if (HealthExpend > 0)
            {
                health = HealthExpend / 2;
            }

            tax -= health;

            return tax;
        }
    }
}
