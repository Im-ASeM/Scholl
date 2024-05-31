public class RProccesScholl : IStudent 
{
    Context db = new Context();

    public void AddNewStudent(NewStudent student)
    {
        Student profile = new Student{
            FullName = student.FullName,
            StudentClass = student.StudentClass,
            NationalCode = student.NationalCode,
            Score = student.Score,
            isPass = student.isPass,
            CreateTime = DateTime.Now,
            ModifyTime = DateTime.Now,
        };
        db.Tdb_Students.Add(profile);
        db.SaveChanges();
    }

    public bool ChangeProfile(SimpleStudent student)
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

    public List<SimpleStudent> ShowAll()
    {
        List<SimpleStudent> results = new List<SimpleStudent>();
        foreach (Student item in db.Tdb_Students.ToList())
        {
            SimpleStudent result = new SimpleStudent{
                Id = item.Id,
                FullName = item.FullName,
                StudentClass = item.StudentClass,
                NationalCode = item.NationalCode,
                Score = item.Score,
                isPass = item.isPass
            };
            results.Add(result);
        }
        return results;
    }
    public List<FullDataStudent> ShowAllDatas()
    {
        List<FullDataStudent> results = new List<FullDataStudent>();
        foreach (Student item in db.Tdb_Students.ToList())
        {
            FullDataStudent result = new FullDataStudent{
                Id = item.Id,
                FullName = item.FullName,
                StudentClass = item.StudentClass,
                NationalCode = item.NationalCode,
                Score = item.Score,
                isPass = item.isPass,
                CreateTime = item.CreateTime,
                ModifyTime = item.ModifyTime
            };
            results.Add(result);
        }
        return results;
    }

    public NewStudent ShowProfile(int id)
    {
        Student chose = db.Tdb_Students.Find(id);
        if(chose == null){
            return null;
        }else{
            NewStudent result = new NewStudent{
                FullName = chose.FullName,
                StudentClass = chose.StudentClass,
                NationalCode = chose.NationalCode,
                Score = chose.Score,
                isPass = chose.isPass,
            };
            return result;
        }
    }
}