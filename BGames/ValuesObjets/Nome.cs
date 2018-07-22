﻿using BGames.Resorces;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace BGames.ValuesObjets
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50,
                Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Primeiro nome", "3", "50"))
                .IfNullOrInvalidLength(x => x.UltimoNome, 3, 50,
                Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Ultimo nome", "3", "50"));

        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }

        public override string ToString() => this.PrimeiroNome + " " + this.UltimoNome;
    }
}
