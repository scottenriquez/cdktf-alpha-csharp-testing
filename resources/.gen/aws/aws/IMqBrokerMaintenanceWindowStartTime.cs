using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMqBrokerMaintenanceWindowStartTime), fullyQualifiedName: "aws.MqBrokerMaintenanceWindowStartTime")]
    public interface IMqBrokerMaintenanceWindowStartTime
    {
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        string DayOfWeek
        {
            get;
        }

        [JsiiProperty(name: "timeOfDay", typeJson: "{\"primitive\":\"string\"}")]
        string TimeOfDay
        {
            get;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        string TimeZone
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerMaintenanceWindowStartTime), fullyQualifiedName: "aws.MqBrokerMaintenanceWindowStartTime")]
        internal sealed class _Proxy : DeputyBase, aws.IMqBrokerMaintenanceWindowStartTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
            public string DayOfWeek
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "timeOfDay", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeOfDay
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeZone
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
