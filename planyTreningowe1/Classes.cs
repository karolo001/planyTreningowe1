namespace planyTreningowe1
{
    public class Exercise
    {
        public string Name { get; set; } = "";
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
        public int OrderIndex { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SureName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PassHash { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }

    }
    public class TrainingDay
    {
        public DateTime Date { get; set; }
        public List<Exercise> ExcerciseList { get; set; } = new List<Exercise>();

    }

}