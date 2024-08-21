using AutoMapper;
using BTG.Credit.Ras.Interview.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BTG.Credit.Ras.Interview.Service
{
    public class MessageChatService : IMessageChatService
    {
        private readonly MessageData _data;
        private readonly IMapper _mapper;
        private MessageChat _lastSentMessage;

        public MessageChatService(MessageData data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public void Send<TInput>(TInput messageReq) where TInput : class
        {
            var msg = _mapper.Map<MessageChat>(messageReq);

            _lastSentMessage = msg;
        }

        public IList<TInput> GetMsgs<TInput>() where TInput : class
        {
            var msgs = _lastSentMessage;
            //var msgs = _mapper.Map<IList<TInput>>(_data.Messages);

            return _mapper.Map<IList<TInput>>(_data.Messages);
        }

        public MessageChat GetLastSentMessage()
        {
            return _lastSentMessage;
        }
    }
}
