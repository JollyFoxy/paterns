using patrns.Activitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns
{
    class Developer
    {
        private IActivity activity;
        public void setActivity(IActivity activity)
        {
            this.activity = activity;
        }

        public void executeActivity()
        {
            activity.DoIt();
        }
    }
}
