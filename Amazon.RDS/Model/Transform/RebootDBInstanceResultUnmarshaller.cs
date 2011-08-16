/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;

using Amazon.Runtime.Internal.Transform;    
    
namespace Amazon.RDS.Model.Transform
{
    /// <summary>
    ///    Result Unmarshaller for RebootDBInstance operation
    /// </summary>
    internal class RebootDBInstanceResultUnmarshaller : IUnmarshaller<RebootDBInstanceResult, UnmarshallerContext> {

        public RebootDBInstanceResult Unmarshall(UnmarshallerContext context) 
        {
            RebootDBInstanceResult result = new RebootDBInstanceResult();
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DBInstance", targetDepth))
                    {
                        result.DBInstance = DBInstanceUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return result;
                }
            }
                       

            return result;
        }
        
        private static RebootDBInstanceResultUnmarshaller instance;
        
        public static RebootDBInstanceResultUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new RebootDBInstanceResultUnmarshaller();
            }
            return instance;
        }        
    }
}    
    
