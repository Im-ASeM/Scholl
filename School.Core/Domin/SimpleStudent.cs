// model for show student with out Unnecessary information
public class SimpleStudent
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string StudentClass { get; set; }
    public string NationalCode { get; set; }
    public decimal Score { get; set; }
    public bool isPass { get; set; }
}