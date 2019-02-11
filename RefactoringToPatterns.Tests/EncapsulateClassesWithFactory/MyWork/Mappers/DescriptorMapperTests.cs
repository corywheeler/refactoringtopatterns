using NUnit.Framework;
using EncapsulateClassesWithFactory.MyWork.Descriptors;
using EncapsulateClassesWithFactory.MyWork.Mappers;
using System.Collections.Generic;

namespace RefactoringToPatterns.EncapsulateClassesWithFactory.MyWork.Mappers
{
    [TestFixture]
    public class DescriptorMapperTests
    {
        TestingDescriptorMapper testDescriptorMapper;

		[SetUp]
        public void Init()
        {
            testDescriptorMapper = new TestingDescriptorMapper();
        }

        [Test]
        public void it_maps_remoteId_descriptor_as_DefaultDescriptor()
        {
            var remoteIdDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("remoteId");

            Assert.AreEqual("DefaultDescriptor", remoteIdDescriptor.GetType().Name);
        }

        [Test]
		public void it_maps_createdDate_descriptor_as_DefaultDescriptor()
		{
			var createdDateDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("createdDate");
            
		    Assert.AreEqual("DefaultDescriptor", createdDateDescriptor.GetType().Name);
        }

		[Test]
		public void it_maps_lastChangedDate_descriptor_as_DefaultDescriptor()
		{
			var lastChangedDateDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("lastChangedDate");

		    Assert.AreEqual("DefaultDescriptor", lastChangedDateDescriptor.GetType().Name);
        }

		[Test]
		public void it_maps_createdBy_descriptor_as_ReferenceDescriptor()
		{
            var createdByDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("createdBy");
            
            Assert.AreEqual("ReferenceDescriptor", createdByDescriptor.GetType().Name);
        }

		[Test]
		public void it_maps_lastChangedBy_descriptor_ReferenceDescriptor()
		{
			var lastChangedByDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("lastChangedBy");

		    Assert.AreEqual("ReferenceDescriptor", lastChangedByDescriptor.GetType().Name);
        }

		[Test]
		public void it_maps_optimisticLockVersion_descriptor_as_DefaultDescriptor()
		{
			var optimisticLockVersionDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("optimisticLockVersion");

		    Assert.AreEqual("DefaultDescriptor", optimisticLockVersionDescriptor.GetType().Name);
        }

		[Test]
		public void it_does_not_map_unknown_descriptors()
		{
            var unknownDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("unknown");
            
			Assert.Null(unknownDescriptor);
		}
    }

    internal class TestingDescriptorMapper : DescriptorMapper {
        List<AttributeDescriptor> descriptors;

        public TestingDescriptorMapper() {
            descriptors = CreateAttributeDescriptors();
        }

		public AttributeDescriptor GetMappedDescriptorFor(string descriptorName)
		{
			return descriptors.Find(descriptor => descriptor.DescriptorName == descriptorName);
		}
    }
}

