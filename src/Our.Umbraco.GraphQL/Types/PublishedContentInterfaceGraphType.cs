using GraphQL;
using GraphQL.Types;
using Umbraco.Core.Models;

namespace Our.Umbraco.GraphQL.Types
{
    [GraphQLMetadata("PublishedContent")]
    public class PublishedContentInterfaceGraphType : InterfaceGraphType<IPublishedContent>
    {
        public PublishedContentInterfaceGraphType()
        {
            Name = "PublishedContent";

            this.AddUmbracoBuiltInProperties();
        }
    }
}
