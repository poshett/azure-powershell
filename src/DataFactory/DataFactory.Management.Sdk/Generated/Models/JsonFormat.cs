// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The data stored in JSON format.
    /// </summary>
    [Newtonsoft.Json.JsonObject("JsonFormat")]
    public partial class JsonFormat : DatasetStorageFormat
    {
        /// <summary>
        /// Initializes a new instance of the JsonFormat class.
        /// </summary>
        public JsonFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JsonFormat class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="serializer">Serializer. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="deserializer">Deserializer. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="filePattern">File pattern of JSON. To be more
        /// specific, the way of separating a collection of JSON objects. The
        /// default value is 'setOfObjects'. It is case-sensitive.</param>
        /// <param name="nestingSeparator">The character used to separate
        /// nesting levels. Default value is '.' (dot). Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="encodingName">The code page name of the preferred
        /// encoding. If not provided, the default value is 'utf-8', unless the
        /// byte order mark (BOM) denotes another Unicode encoding. The full
        /// list of supported values can be found in the 'Name' column of the
        /// table of encodings in the following reference:
        /// https://go.microsoft.com/fwlink/?linkid=861078. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="jsonNodeReference">The JSONPath of the JSON array
        /// element to be flattened. Example: "$.ArrayPath". Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="jsonPathDefinition">The JSONPath definition for each
        /// column mapping with a customized column name to extract data from
        /// JSON file. For fields under root object, start with "$"; for fields
        /// inside the array chosen by jsonNodeReference property, start from
        /// the array element. Example: {"Column1": "$.Column1Path", "Column2":
        /// "Column2PathInArray"}. Type: object (or Expression with resultType
        /// object).</param>
        public JsonFormat(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object serializer = default(object), object deserializer = default(object), object filePattern = default(object), object nestingSeparator = default(object), object encodingName = default(object), object jsonNodeReference = default(object), object jsonPathDefinition = default(object))
            : base(additionalProperties, serializer, deserializer)
        {
            FilePattern = filePattern;
            NestingSeparator = nestingSeparator;
            EncodingName = encodingName;
            JsonNodeReference = jsonNodeReference;
            JsonPathDefinition = jsonPathDefinition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets file pattern of JSON. To be more specific, the way of
        /// separating a collection of JSON objects. The default value is
        /// 'setOfObjects'. It is case-sensitive.
        /// </summary>
        [JsonProperty(PropertyName = "filePattern")]
        public object FilePattern { get; set; }

        /// <summary>
        /// Gets or sets the character used to separate nesting levels. Default
        /// value is '.' (dot). Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "nestingSeparator")]
        public object NestingSeparator { get; set; }

        /// <summary>
        /// Gets or sets the code page name of the preferred encoding. If not
        /// provided, the default value is 'utf-8', unless the byte order mark
        /// (BOM) denotes another Unicode encoding. The full list of supported
        /// values can be found in the 'Name' column of the table of encodings
        /// in the following reference:
        /// https://go.microsoft.com/fwlink/?linkid=861078. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "encodingName")]
        public object EncodingName { get; set; }

        /// <summary>
        /// Gets or sets the JSONPath of the JSON array element to be
        /// flattened. Example: "$.ArrayPath". Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "jsonNodeReference")]
        public object JsonNodeReference { get; set; }

        /// <summary>
        /// Gets or sets the JSONPath definition for each column mapping with a
        /// customized column name to extract data from JSON file. For fields
        /// under root object, start with "$"; for fields inside the array
        /// chosen by jsonNodeReference property, start from the array element.
        /// Example: {"Column1": "$.Column1Path", "Column2":
        /// "Column2PathInArray"}. Type: object (or Expression with resultType
        /// object).
        /// </summary>
        [JsonProperty(PropertyName = "jsonPathDefinition")]
        public object JsonPathDefinition { get; set; }

    }
}
