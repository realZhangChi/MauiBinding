using System.Runtime.InteropServices.JavaScript;
using Foundation;
using UIKit;

namespace Chi.Maui.Binding.iOS.Stripe
{
    // @protocol CompletionCallBack
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Model][Protocol]
    interface CompletionCallBack
    {
        // @required -(void)invokeWithResult:(NSInteger)result;
        [Abstract]
        [Export("invokeWithResult:")]
        void InvokeWithResult(nint result);
    }

    // @interface StripePaymentSheet : NSObject
    [BaseType (typeof(NSObject))]
    interface StripePaymentSheet
    {
        // -(void)ConfigrationWithPaymentIntentClientSecret:(NSString * _Nonnull)paymentIntentClientSecret controller:(UIViewController * _Nonnull)controller;
        [Export ("ConfigrationWithPaymentIntentClientSecret:controller:")]
        void ConfigrationWithPaymentIntentClientSecret (string paymentIntentClientSecret, UIViewController controller);
    }
}
