using System;

namespace nothinbutdotnetstore.web.core
{
    public class MissingRequestCommand : RequestCommand
    {
        public void process(Request request)
        {
            new DefaultResponseEngine().display(request);
        }

        public bool can_handle(Request request)
        {
            throw new NotImplementedException();
        }
    }
}