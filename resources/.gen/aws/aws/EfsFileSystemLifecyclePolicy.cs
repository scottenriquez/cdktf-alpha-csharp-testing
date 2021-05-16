using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EfsFileSystemLifecyclePolicy")]
    public class EfsFileSystemLifecyclePolicy : aws.IEfsFileSystemLifecyclePolicy
    {
        [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TransitionToIa
        {
            get;
            set;
        }
    }
}
