using DAL.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
    }
}
