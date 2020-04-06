using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supply_System.Models
{
    public class TypeViewModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Url { get; set; }
        public static List<TypeViewModel> ListAll()
        {
            List<TypeViewModel> navViewModels = new List<TypeViewModel>();
            navViewModels.Add(new TypeViewModel
            {
                Id = 1,
                TypeName = "招聘信息",
                Url = "",
            });
            navViewModels.Add(new TypeViewModel
            {
                Id = 2,
                TypeName = "公寓信息",
                Url = "",
            });
            navViewModels.Add(new TypeViewModel
            {
                Id = 3,
                TypeName = "家教信息",
                Url = "",
            });
            navViewModels.Add(new TypeViewModel
            {
                Id = 4,
                TypeName = "培训信息",
                Url = "",
            });

            return navViewModels;
        }
    }
}
