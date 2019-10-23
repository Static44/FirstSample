using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstSample.Models;

namespace FirstSample.Controllers
{
    public class HomeController : Controller
    {
        List<GuestResponse> lstGuests = new List<GuestResponse>();

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ListGuests()
        {
            return View(lstGuests);
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }

            else
            {
                return View(guestResponse);
            }
            
        }




    }

    public class RsvpForm
    {
            
    }
}
