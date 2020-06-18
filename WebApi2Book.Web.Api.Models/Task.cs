using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Book.Web.Api.Models
{
    public class Task : ILinkContaining
    {
        private List<Link> _links;
        [Key]
        public long? TaskId { get; set; }
        [Editable(true)]
        public string Subject { get; set; }
        [Editable(true)]
        public DateTime? StartDate { get; set; }
        [Editable(true)]
        public DateTime? DueDate { get; set; }
        [Editable(false)]
        public DateTime? CreatedDate { get; set; }
        [Editable(false)]
        public DateTime? CompletedDate { get; set; }
        [Editable(false)]
        public Status Status { get; set; }
        [Editable(false)]
        public List<User> Assignees { get; set; }
        [Editable(false)]
        public List<Link> Links
        {
            get { return _links ?? (_links = new List<Link>()); }
            set { _links = value; }
        }
        public void AddLink(Link link)
        {
            Links.Add(link);
        }

        private bool _shouldSerializeAssignees;
        public void SetShouldSerializeAssignees(bool shouldSerialize)
        {
            _shouldSerializeAssignees = shouldSerialize;
        }
        public bool ShouldSerializeAssignees()
        {
            return _shouldSerializeAssignees;
        }
    }
}
