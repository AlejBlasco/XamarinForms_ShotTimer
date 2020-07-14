using Helpers.String;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShotTimer.DTOs.Shooting
{
    [Serializable]
    public class SerieDTO: BaseDTO
    {
        public string Name
        {
            get { return _name; }
            set { _name = StringHelper.GetTrimmedValueOrEmpty(value); }
        }
        private string _name = string.Empty;

        public string Description
        {
            get { return _description; }
            set { _description = StringHelper.GetTrimmedValueOrEmpty(value); }
        }
        private string _description = string.Empty;
    }
}
