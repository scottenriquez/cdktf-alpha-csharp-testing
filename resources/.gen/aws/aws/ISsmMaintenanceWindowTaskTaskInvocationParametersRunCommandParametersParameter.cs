using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}