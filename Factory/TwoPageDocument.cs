using System.Collections.Generic;

namespace Factory
{
    class TwoPageDocument : DocumentCreator
    {
        public override void CreatePages()
        {
            Pages.Add(new CoverPage());
            Pages.Add(new FirstPage());
            Pages.Add(new LastPage());
        }
    }
}
