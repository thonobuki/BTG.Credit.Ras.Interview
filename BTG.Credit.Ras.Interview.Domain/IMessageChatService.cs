using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTG.Credit.Ras.Interview.Domain
{
    public interface IMessageChatService
    {
        void Send<TInput>(TInput messageReq) where TInput : class;
        IList<TOutput> GetMsgs<TOutput>() where TOutput : class;
    }
}
