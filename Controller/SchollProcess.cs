using Microsoft.AspNetCore.Mvc;

[Route("[Action]")]
[ApiController]
public class SchollProcess : Controller
{
    IStudent SchoolP;
    public SchollProcess(IStudent _SchoolP)
    {
        SchoolP = _SchoolP;
    }

    [HttpGet]
    public IActionResult ShowStudent(int id){
        Student finder = SchoolP.ShowProfile(id);
        if(finder ==null){
            return NotFound();
        }else{
            MStudentSimple result = new MStudentSimple();
            result.Id=finder.Id;
            result.FullName = finder.FullName;
            result.StudentClass = finder.StudentClass;
            result.NationalCode = finder.NationalCode;
            result.Score = finder.Score;
            result.isPass = finder.isPass;

            return Ok(result);
        }
    }

    [HttpGet]
    public IActionResult ShowStudents(){
        List<MStudentSimple> results = new List<MStudentSimple>();

        foreach (Student finder in SchoolP.ShowAll())
        {
            MStudentSimple result = new MStudentSimple();
            result.Id=finder.Id;
            result.FullName = finder.FullName;
            result.StudentClass = finder.StudentClass;
            result.NationalCode = finder.NationalCode;
            result.Score = finder.Score;
            result.isPass = finder.isPass;
            results.Add(result);
        }
        return Ok(results);
    }

    [HttpPost]
    public IActionResult NewStudent(MStudentNew student){
        SchoolP.AddNewStudent(student);
        return Ok();
    }
    [HttpDelete]
    public IActionResult DelStudent(int id){
        bool isDone = SchoolP.DeleteStudent(id);
        if(isDone){
            return Ok();
        }
        else{
            return NotFound();
        }
    }
    [HttpPut]
    public IActionResult UpdateStudent(MStudentSimple student){
        if(SchoolP.ChangeProfile(student)){
            return Ok();
        }
        else{
            return NotFound();
        }
    }
}