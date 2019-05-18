using System;
using System.Collections.Generic;
using Examine;

namespace LandeSpeiderWebSide.Controllers
{
    public class MySearcher
    {
        public ISearchResults Search(string keywords)
        {
            var searcher = ExamineManager.Instance.SearchProviderCollection["ExternalSearcher"];

            var searchCriteria = searcher.CreateSearchCriteria(Examine.SearchCriteria.BooleanOperation.Or);

            var rawQueries = new List<string>();

            if (!string.IsNullOrWhiteSpace(keywords))
            {
                var words = keywords.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    var contentRawQuery = string.Format(word, 0.5);
                    //var mediaRawQuery = string.Format("(+__IndexType:media -__NodeTypeAlias:folder && (nodeName:{0}~{1}))", word, 0.5);
                    rawQueries.Add(contentRawQuery);
                }
            }
            var query = searchCriteria.RawQuery("(" + String.Join(")(", rawQueries) + ")");

            return searcher.Search(query);
        }
    }
}