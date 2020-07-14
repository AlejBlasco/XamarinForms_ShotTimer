using Helpers.String;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShotTimer.DTOs.Shooting
{
    [Serializable]
    public class SpecialityDTO : BaseDTO
    {
        public string Name
        {
            get { return _name; }
            set { _name = StringHelper.GetTrimmedValueOrEmpty(value); }
        }
        private string _name = string.Empty;

        public SpecialityDTO(string name) 
            : base() 
        {
            this.Name = name;
        }
    }
}
