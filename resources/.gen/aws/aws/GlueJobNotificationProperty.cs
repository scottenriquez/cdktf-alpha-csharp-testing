using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.GlueJobNotificationProperty")]
    public class GlueJobNotificationProperty : aws.IGlueJobNotificationProperty
    {
        [JsiiOptional]
        [JsiiProperty(name: "notifyDelayAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? NotifyDelayAfter
        {
            get;
            set;
        }
    }
}
