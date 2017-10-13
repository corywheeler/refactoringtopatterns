using System;
using System.Collections.Generic;
using EncapsulateClassesWithFactory.MyWork.Descriptors;

namespace EncapsulateClassesWithFactory.MyWork.Mappers
{
    public class DescriptorMapper
    {
        protected List<AttributeDescriptor> CreateAttributeDescriptors() {
            var result = new List<AttributeDescriptor>();

            result.Add(AttributeDescriptor.ForInteger("remoteId", GetType()));
            result.Add(AttributeDescriptor.ForDate("createdDate", GetType()));
            result.Add(AttributeDescriptor.ForDate("lastChangedDate", GetType()));
            result.Add(AttributeDescriptor.ForUser("createdBy", GetType()));
            result.Add(AttributeDescriptor.ForUser("lastChangedBy", GetType()));
            result.Add(AttributeDescriptor.ForInteger("optimisticLockVersion", GetType()));
            return result;
        }
    }
}