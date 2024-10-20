public abstract class AbstractPerson
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    protected AbstractPerson(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }

    public abstract bool Login(string phoneNumber);
}

public class FitnessTrainer : AbstractPerson
{
    public string Specialization { get; set; }

    public FitnessTrainer(string name, string phoneNumber, string specialization)
        : base(name, phoneNumber)
    {
        Specialization = specialization;
    }

    public void LeadTrainingSession(string exercise)
    {
        // Logic to lead a training session
    }

    public override bool Login(string phoneNumber)
    {
        // Logic for trainer login
        return true;
    }
}

public class Client : AbstractPerson
{
    public FitnessCenterProgram Program { get; set; }
    public string CurrentExercise { get; set; }

    public Client(string name, string phoneNumber, FitnessCenterProgram program)
        : base(name, phoneNumber)
    {
        Program = program;
    }

    public void PerformExercise(string exercise)
    {
        // Logic to perform exercise
    }

    public void RecordExercise(string exercise)
    {
        // Logic to record exercise
    }

    public double CalculateCaloriesBurned(double duration)
    {
        // Logic to calculate calories burned
        return duration * 10; // Example calculation
    }

    public void SendProgressToTrainer()
    {
        // Logic to send progress to trainer
    }

    public override bool Login(string phoneNumber)
    {
        // Logic for client login
        return true;
    }
}

public class FitnessCenter
{
    public string Location { get; set; }
    public double MembershipFee { get; set; }

    public FitnessCenter(string location, double membershipFee)
    {
        Location = location;
        MembershipFee = membershipFee;
    }

    public void RequestTrainingSession(FitnessTrainer trainer, string exercise)
    {
        // Logic to request a training session
    }
}

public class FitnessCenterProgram
{
    public string ProgramName { get; set; }
    public string Version { get; set; }

    public FitnessCenterProgram(string programName, string version)
    {
        ProgramName = programName;
        Version = version;
    }

    public void RecordExercise(string exercise)
    {
        // Logic to record exercise
    }

    public double CalculateCaloriesBurned(double duration)
    {
        // Logic to calculate calories burned
        return duration * 10; // Example calculation
    }

    public void SendProgressToTrainer()
    {
        // Logic to send progress to trainer
    }
}
