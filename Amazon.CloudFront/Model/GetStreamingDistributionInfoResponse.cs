/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */

using System.Xml.Serialization;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The GetStreamingDistributionInfoResponse contains all the information about the
    /// GetStreamingDistributionInfo operation and any headers returned by CloudFront.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://cloudfront.amazonaws.com/doc/2010-11-01/", IsNullable = false)]
    public class GetStreamingDistributionInfoResponse : CloudFrontResponse
    {
        #region Private Members

        private CloudFrontStreamingDistribution distribution;

        #endregion

        #region StreamingDistribution
        /// <summary>
        /// Gets and sets the StreamingDistribution property.
        /// This contains all the information (including the configuration) for a
        /// cloudfront StreamingDistribution.
        /// </summary>
        [XmlElementAttribute(ElementName = "StreamingDistribution")]
        public CloudFrontStreamingDistribution StreamingDistribution
        {
            get { return this.distribution; }
            set { this.distribution = value; }
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property.
        /// The Streaming Distribution's ETag is also set if 
        /// possible.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public override string ETag
        {
            set
            {
                this.etagHeader = value;
                if (null != StreamingDistribution)
                {
                    StreamingDistribution.ETag = value;
                }
            }
        }

        #endregion
    }
}