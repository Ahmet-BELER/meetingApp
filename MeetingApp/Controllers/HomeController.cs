using Microsoft.AspNetCore.Mvc;

using MeetingApp.Models;


namespace MeetingApp.Controllers
{
    public class HomeController : Controller{


   public IActionResult  Index()
        {
            int saat =DateTime.Now.Hour ;
            int dakika = DateTime.Now.Minute;
            ViewBag.hours = saat ;
            ViewBag.minute = dakika ; 


            var meetingInfo =   new MeetingInfo()

            {
                Id = 1,
                Location ="Ankara",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = 100,


            };

            return View(meetingInfo );


        }


}



}