using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSale.Models.BusinessModels
{
    public class UserSetting
    {
        public int UserSettingId { get; set; }

        public string UserSettingKey { get; set; }

        public string UserSettingValue { get; set; }
    }
}
