namespace LinqPracticeTask.Model
{
    class Customer
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int OverallTrainingTime { get; set; }

        static List<Customer> _dataTask = new List<Customer>
        {
            new Customer {Id = 1, Year = 2019, Month = 10, OverallTrainingTime = 30 },
            new Customer {Id = 2, Year = 2019, Month = 11, OverallTrainingTime = 35 },
            new Customer {Id = 3, Year = 2019, Month = 11, OverallTrainingTime = 36 },
            new Customer {Id = 4, Year = 2019, Month = 12, OverallTrainingTime = 30 },
        };
    }
}
