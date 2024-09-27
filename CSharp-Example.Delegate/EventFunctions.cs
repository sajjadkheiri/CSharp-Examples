namespace CSharp_Example.Delegate;

public class EventFunctions
{

}

public class TeacherInfoChangeArgs : EventArgs
{
    public string OldName { get; set; }
    public string NewName { get; set; }

    public TeacherInfoChangeArgs(string oldName, string newName)
    {
        OldName = oldName;
        NewName = newName;
    }
}

public class TeacherWithOutEvent
{
    private string _name;
    private string _family;

    public TeacherWithOutEvent(string name, string family)
    {
        _name = name;
        _family = family;
    }

    public void SetName(string newName, string newFamily)
    {
        _name = newName;
        _family = newFamily;
    }

}

public class TeacherWithEvent
{
    public event EventHandler<TeacherInfoChangeArgs> eventChanges;
    public string _name;

    public TeacherWithEvent(string name)
    {
        _name = name;
    }

    public void SetName(string newName)
    {
        var args = new TeacherInfoChangeArgs(_name, newName);
        this._name = newName;
        eventChanges.Invoke(this, args);
    }
}

public class TeacherChangeNameLogger
{
    public void Log(object sender, TeacherInfoChangeArgs args)
    {
        Console.WriteLine($"Old Name : {args.OldName} | New Name : {args.NewName}");
    }
}