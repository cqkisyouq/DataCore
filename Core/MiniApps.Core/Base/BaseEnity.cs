using MiniApps.Core.Interface;
using System;

namespace MiniApps.Core.Base
{
    public class BaseEnity<T> : IBaseEntity
    {
        public T Id { get; set; }
        public int Order { get; set; }
        public bool Deleted { get; set; }
        public bool Enabled { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
