
using System;
using System.Diagnostics;
using ScrollViewTest.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("ScrollViewTest")]
[assembly: ExportEffect(typeof(TestEffectDroid), "TestEffect")]
namespace ScrollViewTest.Droid
{
    public class TestEffectDroid : PlatformEffect
    {

        protected override void OnAttached()
        {
            Debug.WriteLine($"Effect attached to {Element.GetType().ToString()}");
        }

        protected override void OnDetached()
        {
            Debug.WriteLine($"Effect detached from {Element.GetType().ToString()}");
        }
    }
}
