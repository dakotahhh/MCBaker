using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MCBaker.Models
{
    public class Images 
    {
        public List<String> imageList;
        public String directory { get; set; }

        public Images()
        {
            imageList = new List<String>();
            
        }

        public void getImages(String dir)
        {
            directory = dir;
            String fullDirectory = System.Web.HttpContext.Current.Server.MapPath("~/Content/images/" + dir);
            imageList = new DirectoryInfo(fullDirectory).GetFiles("*.jpg").Select(x => x.Name).ToList();
        }
    }
}
