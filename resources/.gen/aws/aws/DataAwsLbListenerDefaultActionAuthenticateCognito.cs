using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsLbListenerDefaultActionAuthenticateCognito), fullyQualifiedName: "aws.DataAwsLbListenerDefaultActionAuthenticateCognito", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsLbListenerDefaultActionAuthenticateCognito : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsLbListenerDefaultActionAuthenticateCognito(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLbListenerDefaultActionAuthenticateCognito(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLbListenerDefaultActionAuthenticateCognito(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AuthenticationRequestExtraParams
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnUnauthenticatedRequest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionCookieName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userPoolClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userPoolDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolDomain
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
