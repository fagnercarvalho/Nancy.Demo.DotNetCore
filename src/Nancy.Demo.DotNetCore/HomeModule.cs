namespace Nancy.Demo.DotNetCore
{
    public sealed class HomeModule : NancyModule
    {
        public HomeModule() : base("api")
        {
            this.Get("/", _ => "Hello World!" );
        }
    }
}
