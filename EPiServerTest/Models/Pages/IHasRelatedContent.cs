using EPiServer.Core;

namespace EPiServerTest.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
