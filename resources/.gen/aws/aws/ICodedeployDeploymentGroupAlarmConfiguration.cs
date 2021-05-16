using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupAlarmConfiguration), fullyQualifiedName: "aws.CodedeployDeploymentGroupAlarmConfiguration")]
    public interface ICodedeployDeploymentGroupAlarmConfiguration
    {
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Alarms
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ignorePollAlarmFailure", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IgnorePollAlarmFailure
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupAlarmConfiguration), fullyQualifiedName: "aws.CodedeployDeploymentGroupAlarmConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupAlarmConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Alarms
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Enabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ignorePollAlarmFailure", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IgnorePollAlarmFailure
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
