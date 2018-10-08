namespace RazorSample.Model
{
    public class Link
    {
        public string Title
        {
            get;
        }

        public string Url
        {
            get;
        }

        public Link(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}