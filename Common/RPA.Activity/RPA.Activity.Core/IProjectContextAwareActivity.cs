namespace RPA.Activity.Core
{
    public interface IProjectContextAwareActivity
    {
        void SetContext(IProjectContext context);
    }

    public interface IProjectContext
    {
        string ProjectRoot { get; set; }
    }
}
