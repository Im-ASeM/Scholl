using Microsoft.AspNetCore.Mvc;

[Route("[Action]")]
[ApiController]
public class SchollProcess : Controller
{
    IStudent SchoolP; //نمونه سازی اینترفیس
    public SchollProcess(IStudent _SchoolP)
    {
        SchoolP = _SchoolP; //متصل کردن اینترفیس به ریپوزیتوری
    }

    [HttpGet] // نشان دادن یک دانش آموز با آیدی
    public IActionResult ShowStudent(int id){  
        NewStudent finder = SchoolP.ShowProfile(id);
        if(finder ==null){
            return NotFound();
        }else{
            return Ok(finder);
        }
    }

    [HttpGet] // نشان دادن همه دانش آموزان
    public IActionResult ShowStudents(){
        return Ok(SchoolP.ShowAll());
    }
    [HttpGet]
    public IActionResult ShowAllData(){
        return Ok(SchoolP.ShowAllDatas());
    }

    [HttpPost]
    public IActionResult NewStudent(NewStudent student){
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
    public IActionResult UpdateStudent(SimpleStudent student){
        if(SchoolP.ChangeProfile(student)){
            return Ok();
        }
        else{
            return NotFound();
        }
    }
}