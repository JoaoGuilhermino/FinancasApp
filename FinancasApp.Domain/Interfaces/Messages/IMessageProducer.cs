using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancasApp.Domain.Entities;

namespace FinancasApp.Domain.Interfaces.Messages
{
    public interface IMessageProducer
    {
        /// <summary>
        /// Metodo para enviar a movimentação para a fila de mensagens.
        /// </summary>
        
        void Send(Movimentacao movimentacao);

    }
}
