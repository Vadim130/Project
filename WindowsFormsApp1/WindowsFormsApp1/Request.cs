using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Request
    {
        public IEvent[] Events;
        public int Id;
        public User UserId;
        public Document Document;
        public Workflow Workflow;

        public bool IsAproved()
        {
            return false;
        }
        public bool IsReject()
        {
            return false;
        }
        public void Approve(User user)
        {

        }
        public void Reject(User user)
        {

        }
        public void Restart()
        {

        }
    }
}
