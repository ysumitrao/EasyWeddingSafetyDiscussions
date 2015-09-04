using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyWeddingRepository;
using EasyWeddingDataAccess.Interface;
using EasyWeddingMiddleLayer.Interface;

namespace EasyWeddingMiddleLayer.Implementation
{
    public class DiscussionDetailsML : IDiscussionDetailsML
    {
        private readonly IDiscussionDetailsDA _discussionDetailsDA;

        public DiscussionDetailsML(IDiscussionDetailsDA discussionDetailsDA)
        {
            _discussionDetailsDA = discussionDetailsDA;
        }       

        public List<DiscussionDetails> GetAllDiscussionDetails()
        {
            return _discussionDetailsDA.GetAllDiscussionDetails();
        }

        public DiscussionDetails GetDiscussionDetail(int discussionId)
        {
            return _discussionDetailsDA.GetDiscussionDetail(discussionId);
        }

        public void AddDiscussion(DiscussionDetails discussionDetail)
        {
            _discussionDetailsDA.AddDiscussion(discussionDetail);
        }

        public void EditDiscussion(DiscussionDetails discussionDetail)
        {
            _discussionDetailsDA.EditDiscussion(discussionDetail);
        }

        public void DeleteDiscussion(DiscussionDetails discussionDetail)
        {
            _discussionDetailsDA.DeleteDiscussion(discussionDetail);
        }
    }
}
