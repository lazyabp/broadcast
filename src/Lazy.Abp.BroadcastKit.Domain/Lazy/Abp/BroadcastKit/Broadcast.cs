using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Lazy.Abp.BroadcastKit
{
    public class Broadcast : FullAuditedAggregateRoot<Guid>
    {
        [NotNull]
        [MaxLength(BroadcastConsts.MaxTitleLength)]
        public virtual string Title { get; protected set; }

        public virtual string FullDescription { get; protected set; }

        public virtual bool IsActive { get; protected set; }

        public virtual DateTime StartTime { get; protected set; }

        public virtual DateTime ExpireTime { get; protected set; }

        protected Broadcast()
        {
        }

        public Broadcast(
            Guid id,
            [NotNull] string title, 
            string fullDescription,
            bool isActive,
            DateTime startTime, 
            DateTime expireTime
        ) : base(id)
        {
            Check.NotNullOrEmpty(title, nameof(title));

            Title = title;
            FullDescription = fullDescription;
            IsActive = isActive;
            StartTime = startTime;
            ExpireTime = expireTime;
        }
    }
}
