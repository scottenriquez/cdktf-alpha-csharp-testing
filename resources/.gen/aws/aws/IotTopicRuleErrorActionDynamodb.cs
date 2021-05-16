using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.IotTopicRuleErrorActionDynamodb")]
    public class IotTopicRuleErrorActionDynamodb : aws.IIotTopicRuleErrorActionDynamodb
    {
        [JsiiProperty(name: "hashKeyField", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HashKeyField
        {
            get;
            set;
        }

        [JsiiProperty(name: "hashKeyValue", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HashKeyValue
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TableName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HashKeyType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Operation
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "payloadField", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PayloadField
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyField", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RangeKeyField
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RangeKeyType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RangeKeyValue
        {
            get;
            set;
        }
    }
}
