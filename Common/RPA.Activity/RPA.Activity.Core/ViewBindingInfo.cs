namespace RPA.Activity.Core
{
    public sealed class ViewBindingInfo
    {
        public ViewBindingInfo()
        {
            this.ViewRegion = ViewRegion.MainArea;
        }
        public IViewContent View { get; set; }

        public ViewRegion ViewRegion { get; set; } 
    }
}
