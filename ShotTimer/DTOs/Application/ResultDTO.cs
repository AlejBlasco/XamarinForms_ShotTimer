using Helpers.String;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShotTimer.DTOs.Application
{
    [Serializable]
    public class ResultDTO
    {
        public bool IsCorrect { get; set; }
        public string Message
        {
            get { return _message; }
            set { _message = StringHelper.GetTrimmedValueOrEmpty(value); }
        }
        private string _message = string.Empty;
        public Exception Ex { get; set; }

        public ResultDTO() 
        {
            this.IsCorrect = true;
            this.Message = string.Empty;
            this.Ex = null;
        }

        public ResultDTO(string message)
        {
            this.IsCorrect = false;
            this.Message = message;
            this.Ex = null;
        }

        public ResultDTO(Exception ex, string message = "") 
        {
            this.IsCorrect = false;
            this.Ex = ex;
            this.Message = !string.IsNullOrWhiteSpace(message)
                ? message
                : ex.Message;
        }
    }
}
