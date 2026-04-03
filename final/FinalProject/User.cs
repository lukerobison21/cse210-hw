using System.Collections.Generic;

public class User
{
    private string _name;
    private List<WorkoutSession> _sessions = new List<WorkoutSession>();

    public User(string name)
    {
        _name = name;
    }

    public void AddSession(WorkoutSession session)
    {
        _sessions.Add(session);
    }
}