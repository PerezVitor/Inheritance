namespace Inheritance1.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company()
        { }

        public Company(string name, double anualincome, int numberOfEmployee) : base (name, anualincome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double TaxPaid()
        {
            if(NumberOfEmployee < 11)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
