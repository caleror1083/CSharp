using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApplicationEvents.Pages;

public class IndexModel : PageModel
{
    private readonly IServiceProvider _provider;

    public int TotalApplications { get; private set; }
    public int TotalUserSessions { get; private set; }

    public IndexModel(IServiceProvider provider)
    {
        _provider = provider;
    }

    public void OnGet()
    {
        var applicationState = (ApplicationState)_provider.GetService(typeof(ApplicationState));
        TotalApplications = applicationState.TotalApplications + 1;
        TotalUserSessions = applicationState.TotalApplications + 1;
    }
}