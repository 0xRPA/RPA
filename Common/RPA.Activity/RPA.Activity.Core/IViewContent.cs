namespace RPA.Activity.Core
{
    public interface IViewContent
    {
        string Name { get; }
        object ViewContent { get; }
    }

    public enum ViewRegion
    {
        MainArea,
        ToolBar
    }
}
