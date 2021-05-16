using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginGroup), fullyQualifiedName: "aws.CloudfrontDistributionOriginGroup")]
    public interface ICloudfrontDistributionOriginGroup
    {
        /// <summary>failover_criteria block.</summary>
        [JsiiProperty(name: "failoverCriteria", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroupFailoverCriteria\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionOriginGroupFailoverCriteria[] FailoverCriteria
        {
            get;
        }

        /// <summary>member block.</summary>
        [JsiiProperty(name: "member", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}")]
        aws.ICloudfrontDistributionOriginGroupMember[] Member
        {
            get;
        }

        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        string OriginId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginGroup), fullyQualifiedName: "aws.CloudfrontDistributionOriginGroup")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionOriginGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>failover_criteria block.</summary>
            [JsiiProperty(name: "failoverCriteria", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroupFailoverCriteria\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionOriginGroupFailoverCriteria[] FailoverCriteria
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionOriginGroupFailoverCriteria[]>()!;
            }

            /// <summary>member block.</summary>
            [JsiiProperty(name: "member", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}")]
            public aws.ICloudfrontDistributionOriginGroupMember[] Member
            {
                get => GetInstanceProperty<aws.ICloudfrontDistributionOriginGroupMember[]>()!;
            }

            [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
