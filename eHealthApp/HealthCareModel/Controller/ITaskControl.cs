using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareModel.Controller
{
    public interface ITaskControl
    {
        void createTask(string taskName, bool status, string description);
    }
}
