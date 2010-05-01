using System;

namespace nothinbutdotnetstore.web.core
{
    public class DefaultFrontController : FrontController
    {
        CommandRegistry command_registry;

        public DefaultFrontController(CommandRegistry command_registry)
        {
            this.command_registry = command_registry;
        }

        public void process(Request request)
        {
            if (request == null) throw new ArgumentNullException();
            if (command_registry == null) throw new ApplicationException();
            var command_that_can_handle_request = command_registry.get_command_that_can_handle(request);
            command_that_can_handle_request.process(request);
        }
    }
}