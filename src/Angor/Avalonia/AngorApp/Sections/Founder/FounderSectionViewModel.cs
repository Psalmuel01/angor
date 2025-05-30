using Angor.UI.Model;
using DynamicData;

namespace AngorApp.Sections.Founder;

public class FounderSectionViewModel : ReactiveObject, IFounderSectionViewModel
{
    public FounderSectionViewModel()
    {
        // projectService.Connect()
        //     .Bind(out var projects)
        //     .Subscribe();
        //
        // Projects = projects;
    }

    public IReadOnlyCollection<IProject> Projects { get;  }
}