using EasyWeddingRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyWeddingMiddleLayer.Interface
{
    public interface IDiscussionDetailsML
    {
        List<DiscussionDetails> GetAllDiscussionDetails();
        DiscussionDetails GetDiscussionDetail(int discussionId);
        void AddDiscussion(DiscussionDetails discussionDetail);
        void EditDiscussion(DiscussionDetails discussionDetail);
        void DeleteDiscussion(DiscussionDetails discussionDetail);
    }
}
