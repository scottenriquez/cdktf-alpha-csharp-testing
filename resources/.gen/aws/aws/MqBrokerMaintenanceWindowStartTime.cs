using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MqBrokerMaintenanceWindowStartTime")]
    public class MqBrokerMaintenanceWindowStartTime : aws.IMqBrokerMaintenanceWindowStartTime
    {
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DayOfWeek
        {
            get;
            set;
        }

        [JsiiProperty(name: "timeOfDay", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TimeOfDay
        {
            get;
            set;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TimeZone
        {
            get;
            set;
        }
    }
}
