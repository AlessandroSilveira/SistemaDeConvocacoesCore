using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;

namespace SistemaDeConvocacoes.Application.ViewModels
{
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
       
    }
}