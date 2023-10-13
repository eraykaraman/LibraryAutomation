using LibraryAutomaiton.Service.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomaiton.Service.Services.Concretes
{
    public class ExceptionService : Exception, IExceptionService
    {
        public string Message { get; set; }

        public ExceptionService()
        {
            
        }
        public ExceptionService(string? message) : base(message)
        {
        }

        public async Task LogExceptionAsync()
        {
            // Logging process, including error message, type, and other necessary information
            string logFilePath = "Logs\\error_log.txt"; // Path to the log file

            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                await sw.WriteLineAsync($"Error Message: {this.Message}");
                await sw.WriteLineAsync($"Error Type: {this.GetType().Name}");
                await sw.WriteLineAsync($"Date: {DateTime.Now}");
                await sw.WriteLineAsync("-------------------------------------------");
            }
        }



    }

}
