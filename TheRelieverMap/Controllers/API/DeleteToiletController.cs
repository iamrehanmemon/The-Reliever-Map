using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TheRelieverMap.Models;

namespace TheRelieverMap.Controllers.API
{
    public class DeleteToiletController : ApiController
    {
        private ApplicationDbContext _context;
        public DeleteToiletController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var toilet = _context.AddToilets.SingleOrDefault(t => t.Id == id && t.Provider.Id == userId);

            toilet.IsCancelled = true;
            _context.SaveChanges();

            return Ok();
        }
    }
}
