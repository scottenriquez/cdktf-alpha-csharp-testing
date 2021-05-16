using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IPinpointAppConfig), fullyQualifiedName: "aws.PinpointAppConfig")]
    public interface IPinpointAppConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>campaign_hook block.</summary>
        [JsiiProperty(name: "campaignHook", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppCampaignHook\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IPinpointAppCampaignHook[]? CampaignHook
        {
            get
            {
                return null;
            }
        }

        /// <summary>limits block.</summary>
        [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppLimits\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IPinpointAppLimits[]? Limits
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>quiet_time block.</summary>
        [JsiiProperty(name: "quietTime", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppQuietTime\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IPinpointAppQuietTime[]? QuietTime
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPinpointAppConfig), fullyQualifiedName: "aws.PinpointAppConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IPinpointAppConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>campaign_hook block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "campaignHook", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppCampaignHook\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IPinpointAppCampaignHook[]? CampaignHook
            {
                get => GetInstanceProperty<aws.IPinpointAppCampaignHook[]?>();
            }

            /// <summary>limits block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppLimits\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IPinpointAppLimits[]? Limits
            {
                get => GetInstanceProperty<aws.IPinpointAppLimits[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>quiet_time block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "quietTime", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.PinpointAppQuietTime\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IPinpointAppQuietTime[]? QuietTime
            {
                get => GetInstanceProperty<aws.IPinpointAppQuietTime[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
