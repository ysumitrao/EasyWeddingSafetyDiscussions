using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyWeddingSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Database.SetInitializer(new Drop DropCreateDatabaseIfModelChanges<EasyWeddingModel>());
            using (var context = new EasyWeddingModel())
            {
                MyEntity entity = new MyEntity();
                entity.Id = 1;
                entity.Name = "Sumit";

                context.MyEntities.Add(entity);

                MyEntity entity1 = new MyEntity();
                entity.Id = 1;
                entity.Name = "Sumit123";

                context.MyEntities.Add(entity);
                context.SaveChanges(); //This saves fine 
            }
            
            
        }
    }
}