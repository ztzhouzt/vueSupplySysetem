    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supply_System.Models
{
    public class SupplyDemandsViewModel
    {
        public int Id { get; set; }
        public string SupplyDemandTitle { get; set; }
        public string SupplyDemandDetail { get; set; }
        public string CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public bool IsRecommend { get; set; }  //是否是推荐
        public bool IsDel { get; set; }

        public static List<SupplyDemandsViewModel> ListAll()
        {
            List<SupplyDemandsViewModel> supplyDemands = new List<SupplyDemandsViewModel>();
            for (int i = 0; i < 8; i++)
            {
                bool IsRecommend = false;
                if (i > 4)
                {
                    IsRecommend = true;
                }
                supplyDemands.Add(new SupplyDemandsViewModel
                {
                    Id = 1,
                    SupplyDemandTitle = "升职加薪，只争朝夕，找工作就来朝夕教育",
                    SupplyDemandDetail = "升职加薪，只争朝夕，就来朝夕教育，欢迎大家来到朝夕教育，共同学习，一起进步",
                    CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CreateUserId = 1,
                    TypeId = 1,
                    TypeName = "招聘信息",
                    IsRecommend = IsRecommend,
                    IsDel = false,
                });
            }
            for (int i = 0; i < 8; i++)
            {
                bool IsRecommend = false;
                if (i > 4)
                {
                    IsRecommend = true;
                }
                supplyDemands.Add(new SupplyDemandsViewModel
                {
                    Id = 1,
                    SupplyDemandTitle = "升职加薪，只争朝夕，找房就来朝夕教育",
                    SupplyDemandDetail = "升职加薪，只争朝夕，就来朝夕教育，欢迎大家来到朝夕教育，共同学习，一起进步",
                    CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CreateUserId = 1,
                    TypeId = 2,
                    TypeName = "公寓信息",
                    IsRecommend = IsRecommend,
                    IsDel = false,
                });
            }
            for (int i = 0; i < 8; i++)
            {
                bool IsRecommend = false;
                if (i > 4)
                {
                    IsRecommend = true;
                }
                supplyDemands.Add(new SupplyDemandsViewModel
                {
                    Id = 1,
                    SupplyDemandTitle = "升职加薪，只争朝夕，找家教就来朝夕教育",
                    SupplyDemandDetail = "升职加薪，只争朝夕，就来朝夕教育，欢迎大家来到朝夕教育，共同学习，一起进步",
                    CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CreateUserId = 1,
                    TypeId = 3,
                    TypeName = "家教信息",
                    IsRecommend = IsRecommend,
                    IsDel = false,
                });
            }
            for (int i = 0; i < 8; i++)
            {
                bool IsRecommend = false;
                if (i > 4)
                {
                    IsRecommend = true;
                }
                supplyDemands.Add(new SupplyDemandsViewModel
                {
                    Id = 1,
                    SupplyDemandTitle = "升职加薪，只争朝夕，就业培训就来朝夕教育",
                    SupplyDemandDetail = "升职加薪，只争朝夕，就来朝夕教育，欢迎大家来到朝夕教育，共同学习，一起进步",
                    CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    CreateUserId = 1,
                    TypeId = 4,
                    TypeName = "培训信息",
                    IsRecommend = IsRecommend,
                    IsDel = false,
                });
            }
            return supplyDemands;
        }
    }
}

