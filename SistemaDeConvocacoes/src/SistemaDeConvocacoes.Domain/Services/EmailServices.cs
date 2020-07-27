using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Enums;
using SistemaDeConvocacoes.Domain.Interfaces.Helper;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using SistemaDeConvocacoes.Domain.Models;

namespace SistemaDeConvocacoes.Domain.Services
{
	public class EmailServices : IEmailServices
	{
		private readonly IConfiguration _configuration;
		private readonly ISysConfig _sysConfig;
		private readonly IConvocacaoService _convocacaoService;
		private readonly IProcessoService _processoService;		
		private readonly IPasswordGeneratorService _passwordGenerator;
		private readonly IConvocadoService _convocadoService;

		public EmailServices(IConfiguration configuration,
			ISysConfig sysConfig,
			IConvocacaoService convocacaoService,
			IProcessoService processoService,
            IPasswordGeneratorService passwordGenerator,
			IConvocadoService convocadoService
			)
		{
			_configuration = configuration;
			_sysConfig = sysConfig;
			_convocacaoService = convocacaoService;
			_processoService = processoService;			
			_passwordGenerator = passwordGenerator;
			_convocadoService = convocadoService;
		}
		public void EnviarEmail(Convocado convocacao)
		{
			//EmailSettings(convocacao);
		}

		private void EmailSettings(Convocado convocacao, string senha=null)
		{
            var mail = new MailMessage {From = new MailAddress(_configuration.ObterEmailFrom())};

            mail.To.Add("alesilver.si@gmail.com");
			mail.Subject = "";
            mail.Body = "";//ObterBodyParaEnvioEmail(convocacao, assuntosEmail);
			mail.IsBodyHtml = true;

            using var smtp = new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = Convert.ToInt32(_configuration.ObterPortaServidorEmail()),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_configuration.ObterEmailFrom(), _configuration.ObterPasswordEmail())
            };

            smtp.Send(mail);
        }

		public void EnviarEmail(string novaSenha, ApplicationUser user)
		{
			var convocado = _convocadoService.Search(a => a.Email.Equals(user.Email)).FirstOrDefault();			

			//EmailSettings(convocado, novaSenha);
		}

        public void EnviarEmail(string novaSenha, ApplicationUser user, AssuntosEmail assuntoEmail)
        {
            throw new NotImplementedException();
        }
    }
}