using System;
using System.Collections.Generic;
using EncapsulateClassesWithFactory.MyWork.Descriptors;

namespace EncapsulateClassesWithFactory.MyWork.Mappers
{
    public class DescriptorMapper
    {
        protected List<AttributeDescriptor> CreateAttributeDescriptors() {
            var result = new List<AttributeDescriptor>();

            result.Add(AttributeDescriptor.ForInteger("remoteId", GetClass()));
            result.Add(AttributeDescriptor.ForDate("createdDate", GetClass()));
            result.Add(AttributeDescriptor.ForDate("lastChangedDate", GetClass()));
            result.Add(AttributeDescriptor.ForUser("createdBy", GetClass()));
            result.Add(AttributeDescriptor.ForUser("lastChangedBy", GetClass()));
            result.Add(AttributeDescriptor.ForInteger("optimisticLockVersion", GetClass()));
            return result;
        }

        private static Type GetClass()
        {
            return typeof(DescriptorMapper);
        }
    }
}