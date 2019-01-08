namespace ExercicioFixHerPoli.Entities
{
    class Company : Payer
    {
        public int NEmployees { get; set; }

        public Company(string name, double anualIncome, int nEmployees) : base(name,anualIncome)
        {
            NEmployees = nEmployees;
        }

        public override double Taxes()
        {
            double tax;

            if (NEmployees > 10)
            {
                tax = AnualIncome * 14 / 100;
            }
            else
            {
                tax = AnualIncome * 16 / 100;
            }

            return tax;
        }
    }
}
