using System;
using EncapsulateClassesWithFactory.MyWork.Domain;

namespace EncapsulateClassesWithFactory.MyWork.Descriptors
{
    public class AttributeDescriptor
    {
        readonly string _descriptorName;
        readonly Type _mapperType;
        readonly Type _forType;

        protected AttributeDescriptor(string descriptorName, Type mapperType, Type forType)
        {
            this._descriptorName = descriptorName;
            this._mapperType = mapperType;
            this._forType = forType;
        }

        public string DescriptorName => _descriptorName;

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

        internal class ReferenceDescriptor : AttributeDescriptor
        {
            internal ReferenceDescriptor(string descriptorName, Type mapperType, Type forType)
                : base(descriptorName, mapperType, forType)
            {
            }
        }

        internal class DefaultDescriptor : AttributeDescriptor
        {
            internal DefaultDescriptor(string descriptorName, Type mapperType, Type forType)
                : base(descriptorName, mapperType, forType)
            {
            }
        }

        internal class BooleanDescriptor : AttributeDescriptor
        {
            internal BooleanDescriptor(string descriptorName, Type mapperType, Type forType)
                : base(descriptorName, mapperType, forType)
            {
            }
        }
    }
}