using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class WorkflowTemplate
    {
        public int Id;
        public string Name;
        public WorkflowStepTemplate[] Steps;

        public Request Create(User user, Document document)
        {
            Request request = new Request();

            return request;
        }
    }
}
