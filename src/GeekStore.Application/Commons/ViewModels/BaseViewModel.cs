using System;

namespace GeekStore.Application.Commons.ViewModels
{
    public class BaseViewModel
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
    }
}
