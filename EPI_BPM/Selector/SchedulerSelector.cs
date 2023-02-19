using EPI_BPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EPI_BPM.Selector
{
    public class SchedulerSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            PMCategory pmCateogry = item as PMCategory;
            FrameworkElement frameworkElement = container as FrameworkElement;

            return (DataTemplate)frameworkElement.FindResource(
                pmCateogry.ManufacturingStatus == "개발"
                ?"PMScheduler1"
                :"PMScheduler2"
                );
        }
    }
}
