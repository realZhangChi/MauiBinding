using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Runtime;

// ReSharper disable once CheckNamespace
namespace Com.Stripe.Android.Databinding;

public partial class StripePaymentAuthWebViewActivityBinding
{
    public unsafe global::Android.Views.View Root
    {

        get
        {
            const string __id = "getRoot.()Landroid/widget/RelativeLayout;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Android.Views.View>(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
            }
            finally
            {
            }
        }
    }
}

