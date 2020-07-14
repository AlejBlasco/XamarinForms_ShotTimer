using System;
using System.Collections.Generic;
using System.Text;

namespace ShotTimer.DTOs
{
    [Serializable]
    public class BaseDTO
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        public BaseDTO() 
        {
            this.CreatedOn = DateTime.Now;
            this.ModifiedOn = DateTime.Now;
        }
    }
}
