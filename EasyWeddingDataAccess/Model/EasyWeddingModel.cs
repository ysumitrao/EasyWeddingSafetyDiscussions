using EasyWeddingRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyWeddingDataAccess.Model
{
    public class EasyWeddingModel : DbContext
    {
        public EasyWeddingModel()
            : base("name=EasyWeddingModel")
        {
        }

        public virtual DbSet<DiscussionDetails> discussionDetails { get; set; }
    }
}
