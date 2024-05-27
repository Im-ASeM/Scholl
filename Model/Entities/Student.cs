using System.ComponentModel.DataAnnotations;
using System.Data;

public class Student
{
    [Key]
    public int Id { get; set; }
    public string FullName { get; set; }
    public string StudentClass { get; set; }
    public string NationalCode { get; set; }
    public decimal Score { get; set; }
    public bool isPass { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime ModifyTime { get; set; }

}