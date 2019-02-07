// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class HttpProfile
    {
        /// <summary>
        /// Initializes a new instance of the HttpProfile class.
        /// </summary>
        public HttpProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpProfile class.
        /// </summary>
        public HttpProfile(string name = default(string), string httpUrls = default(string), string httpCookies = default(string), string httpMessageTransform = default(string), string httpRequestHeaders = default(string), string httpPostRequest = default(string), string httpResponseHeaders = default(string), string httpGetResponse = default(string), string httpPostResponse = default(string), int? id = default(int?))
        {
            Name = name;
            HttpUrls = httpUrls;
            HttpCookies = httpCookies;
            HttpMessageTransform = httpMessageTransform;
            HttpRequestHeaders = httpRequestHeaders;
            HttpPostRequest = httpPostRequest;
            HttpResponseHeaders = httpResponseHeaders;
            HttpGetResponse = httpGetResponse;
            HttpPostResponse = httpPostResponse;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpUrls")]
        public string HttpUrls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpCookies")]
        public string HttpCookies { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpMessageTransform")]
        public string HttpMessageTransform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpRequestHeaders")]
        public string HttpRequestHeaders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpPostRequest")]
        public string HttpPostRequest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpResponseHeaders")]
        public string HttpResponseHeaders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpGetResponse")]
        public string HttpGetResponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpPostResponse")]
        public string HttpPostResponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

    }
}
