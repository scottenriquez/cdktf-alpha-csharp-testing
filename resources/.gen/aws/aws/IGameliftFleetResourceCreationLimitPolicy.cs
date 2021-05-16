using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IGameliftFleetResourceCreationLimitPolicy), fullyQualifiedName: "aws.GameliftFleetResourceCreationLimitPolicy")]
    public interface IGameliftFleetResourceCreationLimitPolicy
    {
        [JsiiProperty(name: "newGameSessionsPerCreator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NewGameSessionsPerCreator
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "policyPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PolicyPeriodInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetResourceCreationLimitPolicy), fullyQualifiedName: "aws.GameliftFleetResourceCreationLimitPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.IGameliftFleetResourceCreationLimitPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "newGameSessionsPerCreator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NewGameSessionsPerCreator
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "policyPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PolicyPeriodInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
