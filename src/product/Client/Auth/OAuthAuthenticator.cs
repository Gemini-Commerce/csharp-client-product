/*
 * Product Service
 *
 * Introducing our revolutionary Product Management Service! Designed to streamline your product inventory and elevate customer experiences, our cutting-edge protobuf service is a game-changer in the world of efficient product management.  With our service, you can effortlessly create new products, allowing you to quickly bring your ideas to life and expand your catalog. Retrieve product information in a snap, providing accurate and personalized details to your customers based on their specific needs and preferences.  Stay ahead of the competition by easily updating product information, ensuring your catalog is always up-to-date and optimized. Seamlessly remove products from your inventory when needed, maintaining a clean and relevant product selection.  Enhance the visual appeal of your products with our advanced media gallery functionalities. Effortlessly add and update captivating images and videos to showcase your products in the best possible light, engaging your customers and driving conversions.  Personalization is key in today's market, and our service enables you to offer unique options to your customers. Easily create and manage lists of customizable options for your products, providing flexibility and tailoring to individual preferences.  Attributes play a vital role in defining products, and our service empowers you to effectively manage them. From bulk attribute creation to listing and retrieving attribute options, our service ensures your product information is rich and comprehensive.  Our service extends its capabilities to entity management, allowing you to effortlessly handle different entities and create customized options lists associated with them. This provides further flexibility and customization options for your product offerings.  When it comes to bulk updates, our service has you covered. Effortlessly update multiple products simultaneously, saving you time and streamlining your operations.  Finding specific products and variants is a breeze with our service. Quickly locate products based on their unique stock keeping unit (SKU) values, ensuring efficient inventory management and smooth order fulfillment.  Experience a new level of efficiency and productivity with our Product Management Service. Unlock the full potential of streamlined product management and empower your business to thrive in today's competitive market. Try our service today and elevate your product management to new heights!
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace product.Client.Auth
{
    /// <summary>
    /// An authenticator for OAuth2 authentication flows
    /// </summary>
    public class OAuthAuthenticator : AuthenticatorBase
    {
        readonly string _tokenUrl;
        readonly string _clientId;
        readonly string _clientSecret;
        readonly string _grantType;
        readonly JsonSerializerSettings _serializerSettings;
        readonly IReadableConfiguration _configuration;

        /// <summary>
        /// Initialize the OAuth2 Authenticator
        /// </summary>
        public OAuthAuthenticator(
            string tokenUrl,
            string clientId,
            string clientSecret,
            OAuthFlow? flow,
            JsonSerializerSettings serializerSettings,
            IReadableConfiguration configuration) : base("")
        {
            _tokenUrl = tokenUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
            _serializerSettings = serializerSettings;
            _configuration = configuration;

            switch (flow)
            {
                /*case OAuthFlow.ACCESS_CODE:
                    _grantType = "authorization_code";
                    break;
                case OAuthFlow.IMPLICIT:
                    _grantType = "implicit";
                    break;
                case OAuthFlow.PASSWORD:
                    _grantType = "password";
                    break;*/
                case OAuthFlow.APPLICATION:
                    _grantType = "client_credentials";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Creates an authentication parameter from an access token.
        /// </summary>
        /// <param name="accessToken">Access token to create a parameter from.</param>
        /// <returns>An authentication parameter.</returns>
        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            var token = string.IsNullOrEmpty(Token) ? await GetToken().ConfigureAwait(false) : Token;
            return new HeaderParameter(KnownHeaders.Authorization, token);
        }

        /// <summary>
        /// Gets the token from the OAuth2 server.
        /// </summary>
        /// <returns>An authentication token.</returns>
        async Task<string> GetToken()
        {
            var client = new RestClient(_tokenUrl,
                configureSerialization: serializerConfig => serializerConfig.UseSerializer(() => new CustomJsonCodec(_serializerSettings, _configuration)));

            var request = new RestRequest()
                .AddParameter("grant_type", _grantType)
                .AddParameter("client_id", _clientId)
                .AddParameter("client_secret", _clientSecret);
            var response = await client.PostAsync<TokenResponse>(request).ConfigureAwait(false);
            
            // RFC6749 - token_type is case insensitive.
            // RFC6750 - In Authorization header Bearer should be capitalized.
            // Fix the capitalization irrespective of token_type casing.
            switch (response.TokenType?.ToLower())
            {
                case "bearer":
                    return $"Bearer {response.AccessToken}";
                default:
                    return $"{response.TokenType} {response.AccessToken}";
            }
        }
    }
}
