using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGameliftFleetRuntimeConfiguration), fullyQualifiedName: "aws.GameliftFleetRuntimeConfiguration")]
    public interface IGameliftFleetRuntimeConfiguration
    {
        [JsiiProperty(name: "gameSessionActivationTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GameSessionActivationTimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxConcurrentGameSessionActivations", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentGameSessionActivations
        {
            get
            {
                return null;
            }
        }

        /// <summary>server_process block.</summary>
        [JsiiProperty(name: "serverProcess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetRuntimeConfigurationServerProcess\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IGameliftFleetRuntimeConfigurationServerProcess[]? ServerProcess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetRuntimeConfiguration), fullyQualifiedName: "aws.GameliftFleetRuntimeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IGameliftFleetRuntimeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "gameSessionActivationTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GameSessionActivationTimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentGameSessionActivations", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentGameSessionActivations
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>server_process block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverProcess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GameliftFleetRuntimeConfigurationServerProcess\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IGameliftFleetRuntimeConfigurationServerProcess[]? ServerProcess
            {
                get => GetInstanceProperty<aws.IGameliftFleetRuntimeConfigurationServerProcess[]?>();
            }
        }
    }
}
