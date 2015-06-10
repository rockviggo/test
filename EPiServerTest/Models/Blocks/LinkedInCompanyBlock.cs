using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServerTest.Models;
using EPiServerTest;

namespace EPiServerTest.Models.Blocks
{
    [ContentType(
        GUID = "419db9dd-44bc-4540-b446-fcb5f6d588fa",
        GroupName = "Social media")]
    [SiteImageUrl]
    public class LinkedInCompanyBlock : BlockData
    {
        [Display(
            Name = "Company name",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual String CompanyName { get; set; }
    }
}