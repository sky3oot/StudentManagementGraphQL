﻿
using StudentDetails.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZA365Solutions.Platform.Messaging;

namespace StudentDetails.Abstraction.Student.Command
{
  public  class RemoveStudent:ICommand<EntityId>
    {
        public RemoveStudent()
        {
            CommandId = Guid.NewGuid();
        }
        public string UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public string UserEmail { get; set; }
        public Guid CommandId { get; }
        public string Name => GetType().Name.ToLower();
        public EntityId CommandData { get; set; }
        public DateTime CommandTime { get; set; }
    }
}
