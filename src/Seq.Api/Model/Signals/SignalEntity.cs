﻿using System;
using System.Collections.Generic;

namespace Seq.Api.Model.Signals
{
    public class SignalEntity : Entity
    {
        public SignalEntity()
        {
            Title = "New Signal";
            Filters = new List<SignalFilterPart>();
            TaggedProperties = new List<TaggedPropertyPart>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<SignalFilterPart> Filters { get; set; }

        public List<TaggedPropertyPart> TaggedProperties { get; set; }

        public bool IsWatched { get; set; }

        [Obsolete("This member has been renamed `IsProtected` to better reflect its purpose.")]
        // ReSharper disable once UnusedMember.Global
        public bool? IsRestricted { get; set; }

        public bool IsProtected { get; set; }

        public SignalGrouping Grouping { get; set; }

        public string ExplicitGroupName { get; set; }
    }
}
