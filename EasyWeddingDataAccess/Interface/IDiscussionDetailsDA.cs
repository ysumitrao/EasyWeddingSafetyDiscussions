using EasyWeddingRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyWeddingDataAccess.Interface
{
    public interface IDiscussionDetailsDA
    {
        List<DiscussionDetails> GetAllDiscussionDetails();
        DiscussionDetails GetDiscussionDetail(int discussionId);
        void AddDiscussion(DiscussionDetails discussionDetail);
        void EditDiscussion(DiscussionDetails discussionDetail);
        void DeleteDiscussion(DiscussionDetails discussionDetail);
    }
}
