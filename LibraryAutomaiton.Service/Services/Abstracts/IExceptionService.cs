using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomaiton.Service.Services.Abstracts
{
    public interface IExceptionService
    {
        string Message { get; set; }
        Task LogExceptionAsync();
    }
}
