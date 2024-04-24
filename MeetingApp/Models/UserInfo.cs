using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models

{

  public class UserInfo
{
     public int  id { get; set; }
     [Required (ErrorMessage = "Ad Alanı Zorunlu")]
    public string? Name { get; set; }
    [Required (ErrorMessage = "Telefon Alanı Zorunlu")]
    public string? Phone { get; set; }

   [Required (ErrorMessage = "Mail  Alanı Zorunlu")]
   [EmailAddress]
    public string? Email { get; set; }
 [Required (ErrorMessage = "Ad Alanı Zorunlu")]
    public bool? WillAttend { get; set; }
}
}
