public interface IStudent
{
    public NewStudent ShowProfile(int id);
    public List<SimpleStudent> ShowAll();
    public List<FullDataStudent> ShowAllDatas();
    public void AddNewStudent(NewStudent student);
    public bool ChangeProfile(SimpleStudent student);
    public bool DeleteStudent(int id);
}