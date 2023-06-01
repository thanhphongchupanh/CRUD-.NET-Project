using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ServiceBase<T> where T : class
    {
        BankAccountTypeContext _context;  //kết nối CSDL
        DbSet<T> _dbSet;    // là class của EntityFramework để thao tác trên các bảng của CSDL

        public ServiceBase()
        {
            _context = new BankAccountTypeContext();
            _dbSet = _context.Set<T>();       // gán dữ liệu từ DB vào bảng T vào biến _dbSet
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Create(T entity)       //entity là 1 Obj
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            //try
            //{
            _dbSet.Remove(entity);
            _context.SaveChanges();
            //    return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}

        }

        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);    //vì hàm Update của DbSet đôi khi không hoạt động
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }


    }
}
