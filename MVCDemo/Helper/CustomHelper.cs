using System.Web.Mvc;

namespace MVCDemo.Helper
{
    public static class CustomHelper
    {
        public static MvcHtmlString orderedList(this HtmlHelper htmlHelper, string[] words)
        {
            var headingTag = new TagBuilder("h2");
            headingTag.InnerHtml = "This Order List using extention method";

            var orderedListTag = new TagBuilder("ol");

            string innerHtml = string.Empty;

            foreach(string word in words)
            {
                var liTag = new TagBuilder("li");
                liTag.InnerHtml = word;

                innerHtml = innerHtml + liTag;
            }
            orderedListTag.InnerHtml = innerHtml;
            return MvcHtmlString.Create(headingTag.ToString() + orderedListTag.ToString());
        }

        public static MvcHtmlString orderedList(string[] words)
        {
            var headingTag = new TagBuilder("h2");
            headingTag.InnerHtml = "This Order List using static method";

            var orderedListTag = new TagBuilder("ol");

            string innerHtml = string.Empty;

            foreach (string word in words)
            {
                var liTag = new TagBuilder("li");
                liTag.InnerHtml = word;

                innerHtml = innerHtml + liTag;
            }
            orderedListTag.InnerHtml = innerHtml;
            return MvcHtmlString.Create(headingTag.ToString() + orderedListTag.ToString());
        }

    }
}