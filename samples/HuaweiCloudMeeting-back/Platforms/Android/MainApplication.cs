using Android.App;
using Android.Runtime;

namespace HuaweiCloudMeeting
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override void OnCreate()
        {
            base.OnCreate();
            
            //            var sdkConfig = new Com.Huawei.Cloudlink.Openapi.OpenSDKConfig(this)
            //    .SetAppId("fdb8e4699586458bbd10c834872dcc62")    //设置唯一App ID，可填应用英文名，使用App ID登录必须要设
            //    .SetServerAddress("meeting.huaweicloud.com")   //设置会议服务器地址
            //    .SetServerPort("443");  //设置会议服务器端口
            //Com.Huawei.Cloudlink.Openapi.HWMSdk.Init(this, sdkConfig);
        }
    }
}