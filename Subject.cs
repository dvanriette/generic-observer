public class Subject{
    private List<IObserver> observers=new List<IObserver>();
    private string value="";

    public void RegisterObserver(IObserver observer){
        this.observers.Add(observer);
    }

    public void UnRegisterObserver(IObserver observer){
        this.observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        foreach(IObserver o in this.observers){
            o.update(this.value);
        }
    }

    public void ChangeSubjectValue(string value){
        this.value = value;
    }
}