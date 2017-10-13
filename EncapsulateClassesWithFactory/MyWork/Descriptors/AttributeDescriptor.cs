using System;
using EncapsulateClassesWithFactory.MyWork.Domain;

namespace EncapsulateClassesWithFactory.MyWork.Descriptors
{
    public class AttributeDescriptor
    {
        readonly string descriptorName;
        readonly Type mapperType;
        readonly Type forType;

        protected AttributeDescriptor(string descriptorName, Type mapperType, Type forType)
        {
            this.descriptorName = descriptorName;
            this.mapperType = mapperType;
            this.forType = forType;
        }

        public string DescriptorName => descriptorName;

        public static AttributeDescriptor ForInteger(string descriptorName, Type classType)
        {
            return new DefaultDescriptor(descriptorName, classType, typeof(int));
        }

        public static AttributeDescriptor ForDate(string descriptorName, Type mapperType)
        {
            return new DefaultDescriptor(descriptorName, mapperType, typeof(DateTime));
        }

        public static AttributeDescriptor ForUser(string descriptorName, Type mapperType)
        {
            return new ReferenceDescriptor(descriptorName, mapperType, typeof(User));
        }
    }
}