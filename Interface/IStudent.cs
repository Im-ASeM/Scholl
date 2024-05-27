using Microsoft.AspNetCore.Mvc;

public interface IStudent
{
    public Student ShowProfile(int id);
    public List<Student> ShowAll();
    public void AddNewStudent(MStudentNew student);
    public bool ChangeProfile(MStudentSimple student);
    public bool DeleteStudent(int id);
}