using Chi.Maui.Binding.iOS.Stripe;
using Microsoft.Maui.Platform;
using ObjCRuntime;

namespace Demo;

public partial class MainPage : ContentPage
{
    int count = 0;
    private CallBack _callBack = new CallBack();

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var payment = new StripePaymentSheet();
        var secret = "pi_3NdD42LikjSSv4TD28olCvik_secret_zDLha8FUI1WilQ4HLxlT0yS1p";
        payment.ConfigrationWithPaymentIntentClientSecret(secret, Platform.GetCurrentUIViewController());
        
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

public class CallBack : ICompletionCallBack, INativeObject, IDisposable
{
    public NativeHandle Handle { get; set; }
    
    public void InvokeWithResult(nint result)
    {
        
    }
    
    public void Dispose(){}
}