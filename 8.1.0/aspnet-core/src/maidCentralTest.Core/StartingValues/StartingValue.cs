using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using maidCentralTest.Authorization.Users;
using System;

namespace maidCentralTest.StartingValues
{
    [AutoMapTo(typeof(StartingValuesDto))]
    public class StartingValue : Entity<int>, IFullAudited<User>
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public User CreatorUser { get; set; }
        public User LastModifierUser { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public User DeleterUser { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
