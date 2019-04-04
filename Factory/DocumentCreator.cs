using System.Collections.Generic;

namespace Factory
{
    abstract class DocumentCreator
    {
        public List<Page> Pages { get; set; }

        public DocumentCreator()
        {
            Pages = new List<Page>();
            this.CreatePages();
        }

        public abstract void CreatePages();
    }
}
