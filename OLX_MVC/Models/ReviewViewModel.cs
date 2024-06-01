using Microsoft.AspNetCore.Mvc;
using OLX_MVC.Data.Entities;
using RozetkaMVC.Data.Entities;

namespace RozetkaMVC.Models
{
    public class ReviewViewModel
    {
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
    }
}
