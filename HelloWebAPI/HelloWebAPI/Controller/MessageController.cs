using HelloWebAPI.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HelloWebAPI.Controller
{
    public class MessageController : ApiController
    {
        // GET: api/Message
        public IEnumerable<Message> Get()
        {
           
            WarungPintarDataContext db = new WarungPintarDataContext();

            return db.Messages.ToList();
        }

        // GET: api/Message/5
        public Message Get(int id)
        {
            WarungPintarDataContext db = new WarungPintarDataContext();

            return db.Messages.Where(x => x.MessageID == id).SingleOrDefault();
        }

        // POST: api/Message
        public void Post([FromBody]Message body)
        {
            string a = body.Kepada;
            string b = body.Subject;
            string C = body.Body;

            Message msg = new Message()

            {
                Kepada = a,
                Subject = b,
                Body = C

            };
            WarungPintarDataContext db = new WarungPintarDataContext();

            db.Messages.InsertOnSubmit(msg);
            db.SubmitChanges();

        }

        // PUT: api/Message/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Message/5
        public void Delete(int id)
        {
        }
    }
}
