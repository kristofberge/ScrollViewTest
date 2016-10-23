
using System.Diagnostics;
using ScrollViewTest.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("ScrollViewTest")]
[assembly: ExportEffect(typeof(TestEffectiOS), "TestEffect")]
namespace ScrollViewTest.iOS
{
    public class TestEffectiOS : PlatformEffect
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