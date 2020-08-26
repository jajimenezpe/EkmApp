using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EkmApp.Models
{
    public class MemberViewModel
    {
        public List<Member> Members { get; set; }
        public SelectList Membership { get; set; } = new SelectList(new List<string>(new string[] { "Bronze", "Silver", "Gold", "Platinum" }));
        public string FilterMembership { get; set; }
        public string SearchString { get; set; }
    }
}
