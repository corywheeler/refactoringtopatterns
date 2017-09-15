using System;
using System.Collections.Generic;
using EncapsulateClassesWithFactory.MyWork.Descriptors;
using EncapsulateClassesWithFactory.MyWork.Domain;

namespace EncapsulateClassesWithFactory.MyWork.Mappers
{
    public class DescriptorMapper
    {
        protected List<AttributeDescriptor> CreateAttributeDescriptors() {
            var result = new List<AttributeDescriptor>();

            result.Add(new DefaultDescriptor("remoteId", GetClass(), typeof(int)));
            result.Add(new DefaultDescriptor("createdDate", GetClass(), typeof(DateTime)));
            result.Add(new DefaultDescriptor("lastChangedDate", GetClass(), typeof(DateTime)));
            result.Add(new ReferenceDescriptor("createdBy", GetClass(), typeof(User)));
            result.Add(new ReferenceDescriptor("lastChangedBy", GetClass(), typeof(User)));
            result.Add(new DefaultDescriptor("optimisticLockVersion", GetClass(), typeof(int)));
            return result;
        }

        private Type GetClass()
        {
            return typeof(DescriptorMapper);
        }
    }
}