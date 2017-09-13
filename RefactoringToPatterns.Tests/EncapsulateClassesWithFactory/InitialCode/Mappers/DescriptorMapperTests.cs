using NUnit.Framework;
using EncapsulateClassesWithFactory.InitialCode.Descriptors;
using EncapsulateClassesWithFactory.InitialCode.Mappers;
using System.Collections.Generic;

namespace RefactoringToPatterns.EncapsulateClassesWithFactory.InitialCode.Mappers
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
        public void it_maps_remoteId_descriptor()
        {
            var remoteIdDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("remoteId");
            
            Assert.NotNull(remoteIdDescriptor);
        }

        [Test]
		public void it_maps_createdDate_descriptor()
		{
			var createdDateDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("createdDate");
            
			Assert.NotNull(createdDateDescriptor);
		}

		[Test]
		public void it_maps_lastChangedDate_descriptor()
		{
			var lastChangedDateDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("lastChangedDate");
            
			Assert.NotNull(lastChangedDateDescriptor);
		}

		[Test]
		public void it_maps_createdBy_descriptor()
		{
            var createdByDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("createdBy");
            
			Assert.NotNull(createdByDescriptor);
		}

		[Test]
		public void it_maps_lastChangedBy_descriptor()
		{
			var lastChangedByDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("lastChangedBy");
            
			Assert.NotNull(lastChangedByDescriptor);
		}

		[Test]
		public void it_maps_optimisticLockVersion_descriptor()
		{
			var optimisticLockVersionDescriptor = 
                testDescriptorMapper.GetMappedDescriptorFor("optimisticLockVersion");
            
			Assert.NotNull(optimisticLockVersionDescriptor);
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

