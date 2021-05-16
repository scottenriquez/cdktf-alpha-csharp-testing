using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupTriggerConfiguration), fullyQualifiedName: "aws.CodedeployDeploymentGroupTriggerConfiguration")]
    public interface ICodedeployDeploymentGroupTriggerConfiguration
    {
        [JsiiProperty(name: "triggerEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TriggerEvents
        {
            get;
        }

        [JsiiProperty(name: "triggerName", typeJson: "{\"primitive\":\"string\"}")]
        string TriggerName
        {
            get;
        }

        [JsiiProperty(name: "triggerTargetArn", typeJson: "{\"primitive\":\"string\"}")]
        string TriggerTargetArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupTriggerConfiguration), fullyQualifiedName: "aws.CodedeployDeploymentGroupTriggerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ICodedeployDeploymentGroupTriggerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "triggerEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TriggerEvents
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "triggerName", typeJson: "{\"primitive\":\"string\"}")]
            public string TriggerName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "triggerTargetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TriggerTargetArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
