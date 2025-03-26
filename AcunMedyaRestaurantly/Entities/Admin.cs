using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AcunMedyaRestaurantly.Entities
{
	public class Admin
	{
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }

        [NotMapped] //veri tabanına kaydetmiyor
        public HttpPostedFileBase ImageFile { get; set; } // tabloda gözükmesini sağlayacak ama veri tabanına kaydolmayacak

        [NotMapped] 
        public string CurrentPassword { get; set; }

        [NotMapped]
        public string NewPassword { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }

    }
}