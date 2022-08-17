using BLL.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class MessageManager:IMessageService
    {
        IMessageDal _MessageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _MessageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _MessageDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListInbox()
        {
            return _MessageDal.List(x=>x.Receiver=="admin@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            return _MessageDal.List(x => x.Sender == "admin@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            _MessageDal.Insert(message); 
        }

        public void MessageDelete(Message message)
        {
             _MessageDal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _MessageDal.Update(message);
        }
    }
}
