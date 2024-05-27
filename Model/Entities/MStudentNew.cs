using System.ComponentModel.DataAnnotations;

public class MStudentNew
{
    public string FullName { get; set; }
    public string StudentClass { get; set; }
    public string NationalCode { get; set; }
    public decimal Score { get; set; }
    public bool isPass { get; set; }
}