

using System;
using YZL5155_Abstract_3.Model.Entities.Enums;

namespace YZL5155_Abstract_3.Model.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }

        DateTime _createDate = DateTime.Now;
        public DateTime CreateDate 
        {
            get => _createDate;
            set => _createDate = value;
        }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }


        private Status _status = Status.Active;
        public Status Status 
        {
            get => _status;
            set => _status = value; 
        }
    }
}
