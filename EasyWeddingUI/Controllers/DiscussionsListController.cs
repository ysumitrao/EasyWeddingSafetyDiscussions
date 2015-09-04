using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyWeddingMiddleLayer.Interface;
using EasyWeddingRepository;

namespace EasyWeddingUI.Controllers
{
    public class DiscussionsListController : ApiController
    {
        private readonly IDiscussionDetailsML _discussionDetailsML;

        public DiscussionsListController(IDiscussionDetailsML discussionDetailsML)
        {
            _discussionDetailsML = discussionDetailsML;
        }
        
        // GET: api/DiscussionsList
        public List<DiscussionDetails> Get()
        {
            return _discussionDetailsML.GetAllDiscussionDetails();
        }

        // GET: api/DiscussionsList/5
        public DiscussionDetails Get(int id)
        {
            return _discussionDetailsML.GetDiscussionDetail(id);
        }

        // POST: api/DiscussionsList
        public void Post([FromBody]DiscussionDetails discussionDetails)
        {
            _discussionDetailsML.AddDiscussion(discussionDetails);
        }

        // PUT: api/DiscussionsList/5
        public void Put([FromBody]DiscussionDetails discussionDetails)
        {
            _discussionDetailsML.EditDiscussion(discussionDetails);
        }

        // DELETE: api/DiscussionsList/5
        public void Delete(int id)
        {
            DiscussionDetails discussionDetail = _discussionDetailsML.GetDiscussionDetail(id);
            _discussionDetailsML.DeleteDiscussion(discussionDetail);
        }
    }
}
