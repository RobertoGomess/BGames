using BGames.Domain.Resorces;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;

namespace BGames.ValuesObjets
{
    public class Email : Notifiable
    {
        public Email()
        {

        }
        public Email(string endereco)
        {
            Endereco = endereco;
            new AddNotifications<Email>(this).IfNotEmail(c => endereco , Message.X0_INVALIDO.ToFormat("E-mail"));
        }

        public String Endereco { get; private set; }
    }
}
