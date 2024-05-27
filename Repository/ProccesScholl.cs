using Microsoft.AspNetCore.Mvc;

public class ProccesScholl : IStudent 
{
    Context db = new Context();

    public void AddNewStudent(MStudentNew student)
    {
        Student profile = new Student();
        profile.FullName = student.FullName;
        profile.StudentClass = student.StudentClass;
        profile.NationalCode = student.NationalCode;
        profile.Score = student.Score;
        profile.isPass = student.isPass;
        profile.CreateTime = DateTime.Now;
        profile.ModifyTime = profile.CreateTime;
        db.Tdb_Students.Add(profile);
        db.SaveChanges();
    }

    public bool ChangeProfile(MStudentSimple student)
    {
        Student profile = db.Tdb_Students.Find(student.Id);
        if(profile == null){
            return false ;
        }
        else{
            // mapping simple to Student
            profile.FullName = student.FullName;
            profile.StudentClass = student.StudentClass;
            profile.NationalCode = student.NationalCode;
            profile.Score = student.Score;
            profile.isPass = student.isPass;
            profile.ModifyTime = DateTime.Now;
            db.Tdb_Students.Update(profile);
            db.SaveChanges();
            return true;
        }
    }

    public bool DeleteStudent(int id)
    {
        Student chose = db.Tdb_Students.Find(id);
        if(chose == null){
            return false ;
        }
        else{
            db.Tdb_Students.Remove(chose);
            db.SaveChanges();
            return true;
        }
    }

    public List<Student> ShowAll()
    {
        return db.Tdb_Students.ToList();
    }

    public Student ShowProfile(int id)
    {
        return db.Tdb_Students.Find(id);
    }
}