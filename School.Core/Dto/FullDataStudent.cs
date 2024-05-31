public class FullDataStudent
{
    public int Id { get; set; }  // آیدی !
    public string FullName { get; set; } // نام کامل
    public string StudentClass { get; set; } // شماره کلاس
    public string NationalCode { get; set; } // کد ملی
    public decimal Score { get; set; } // نمره
    public bool isPass { get; set; } //آیا پاس شده ؟ یا مردود شده؟
    public DateTime CreateTime { get; set; }
    public DateTime ModifyTime { get; set; }
}