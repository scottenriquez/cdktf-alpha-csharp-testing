using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAlbListenerDefaultActionAuthenticateOidc), fullyQualifiedName: "aws.DataAwsAlbListenerDefaultActionAuthenticateOidc", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsAlbListenerDefaultActionAuthenticateOidc : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsAlbListenerDefaultActionAuthenticateOidc(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAlbListenerDefaultActionAuthenticateOidc(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAlbListenerDefaultActionAuthenticateOidc(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AuthenticationRequestExtraParams
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "tokenEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userInfoEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserInfoEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
