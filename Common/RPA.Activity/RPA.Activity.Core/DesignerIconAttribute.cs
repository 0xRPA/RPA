using System;
using System.Activities.Presentation;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
#if NET_CORE


#else
using System.Windows.Media.Imaging;
using System.Windows.Threading;
#endif

namespace RPA.Activity.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DesignerIconAttribute : Attribute
    {
        public Type OwnerType { get; set; }

        public string ImageName { get; set; }

        public DesignerIconAttribute(Type activityType, string imageName)
        {
            try
            {
                this.OwnerType = activityType;
                this.ImageName = imageName;
                var projectName = activityType.Module.Assembly.GetName().Name;
                Stream manifestResourceStream =
                    activityType.Module.Assembly.GetManifestResourceStream(projectName + "." + imageName);
                if (manifestResourceStream == null)
                    return;
#if NET_CORE
                
#else
                var bmpframe = BitmapFrame.Create(manifestResourceStream);

                var brush = new DrawingBrush
                {
                    Drawing = new ImageDrawing
                    {
                        Rect = new System.Windows.Rect(0, 0, 16, 16),
                        ImageSource = bmpframe
                    }
                };
#endif

                var prorerty = typeof(WorkflowDesignerIcons).GetProperty("IconResourceDictionary",
                    BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Static);
                if (prorerty == null)
                {
                    return;
                }

                var iconResource = prorerty.GetValue(null) as ResourceDictionary;
                string resourceKey = activityType.Name + "Icon";
                if (iconResource != null && !iconResource.Contains(resourceKey))
                {
#if NET_CORE
                    //TODO



#else
                    Dispatcher.CurrentDispatcher.BeginInvoke(new Action(() =>
                    {
                        if (!iconResource.Contains(resourceKey))
                        {
                            iconResource.Add(resourceKey, brush);
                        }
                    }));
#endif
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
