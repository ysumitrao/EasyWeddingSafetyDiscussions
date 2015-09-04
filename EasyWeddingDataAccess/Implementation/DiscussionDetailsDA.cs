using EasyWeddingDataAccess.Interface;
using EasyWeddingDataAccess.Model;
using EasyWeddingRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyWeddingDataAccess.Implementation
{
    public class DiscussionDetailsDA : IDiscussionDetailsDA, IDisposable
    {
        private readonly EasyWeddingModel repository;
        public DiscussionDetailsDA()
        {
            repository = new EasyWeddingModel();
        }

        public List<DiscussionDetails> GetAllDiscussionDetails()
        {
            return repository.discussionDetails
                .OrderByDescending(details => details.DateOfDiscussion)
                .ToList();
        }

        public DiscussionDetails GetDiscussionDetail(int discussionId)
        {
            return repository.discussionDetails
                .Where(details => details.DiscussionId == discussionId)
                .FirstOrDefault();
        }

        public void AddDiscussion(DiscussionDetails discussionDetail)
        {
            repository.discussionDetails.Add(discussionDetail);
            repository.SaveChanges();
        }

        public void EditDiscussion(DiscussionDetails discussionDetail)
        {
            repository.discussionDetails.Attach(discussionDetail);
            repository.Entry(discussionDetail).State = EntityState.Modified;
            repository.SaveChanges();
        }

        public void DeleteDiscussion(DiscussionDetails discussionDetail)
        {
            repository.discussionDetails.Remove(discussionDetail);
            repository.SaveChanges();
        }

        public void Dispose()
        {
            if (repository != null)
            {
                repository.Dispose();
            }
        }
    }
}
