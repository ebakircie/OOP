using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YLZ5155_Interface_1.Models.Entities.Abstract
{
    public enum Status { Active = 1, Modified = 2, Passive = 3}
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }
        private DateTime _createDate = DateTime.Now;
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

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }

    }
}
