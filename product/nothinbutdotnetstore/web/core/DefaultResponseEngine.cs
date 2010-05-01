namespace nothinbutdotnetstore.web.core
{
    public class DefaultResponseEngine : ResponseEngine
    {
        public void display<ViewModel>(ViewModel view_model)
        {
            throw new UnWiredRequestException("Ensure you have the request registered in CommandRegistry class");
        }
    }
}