using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAwsProviderAssumeRole), fullyQualifiedName: "aws.AwsProviderAssumeRole")]
    public interface IAwsProviderAssumeRole
    {
        /// <summary>The external ID to use when assuming the role.</summary>
        /// <remarks>
        /// If omitted, no external ID is passed to the AssumeRole call.
        /// </remarks>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The permissions applied when assuming a role.</summary>
        /// <remarks>
        /// You cannot use, this policy to grant further permissions that are in excess to those of the,  role that is being assumed.
        /// </remarks>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ARN of an IAM role to assume prior to making API calls.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>The session name to use when assuming the role.</summary>
        /// <remarks>
        /// If omitted, no session name is passed to the AssumeRole call.
        /// </remarks>
        [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAwsProviderAssumeRole), fullyQualifiedName: "aws.AwsProviderAssumeRole")]
        internal sealed class _Proxy : DeputyBase, aws.IAwsProviderAssumeRole
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The external ID to use when assuming the role.</summary>
            /// <remarks>
            /// If omitted, no external ID is passed to the AssumeRole call.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The permissions applied when assuming a role.</summary>
            /// <remarks>
            /// You cannot use, this policy to grant further permissions that are in excess to those of the,  role that is being assumed.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ARN of an IAM role to assume prior to making API calls.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The session name to use when assuming the role.</summary>
            /// <remarks>
            /// If omitted, no session name is passed to the AssumeRole call.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
