using System.Collections.Generic;

namespace Factory
{
    class ThreePageDocument : DocumentCreator
    {
        public override void CreatePages()
        {
            Pages.Add(new CoverPage());
            Pages.Add(new FirstPage());
            Pages.Add(new MiddlePage());
            Pages.Add(new LastPage());
        }
    }
}
