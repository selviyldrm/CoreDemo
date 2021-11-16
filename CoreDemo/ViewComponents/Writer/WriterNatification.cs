using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterNatification : ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = nm.GetList(x => x.NotificationStatus == true);
            if (values.Count() > 3)
            {
                values = values.Take(5).ToList();
            }
            return View(values);
        }
    }
}
