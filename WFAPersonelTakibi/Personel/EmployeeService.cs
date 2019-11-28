﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAPersonelTakibi.Context;
using WFAPersonelTakibi.Personel;

namespace WFAPersonelTakibi.Personel
{
    public class EmployeeService
    {
        private MyContext _context;
        public EmployeeService()
        {
            _context = new MyContext();
        }

        public bool Add(Employee employee)
        {
            _context.Employees.Add(employee);
            return _context.SaveChanges() > 0;
        }

        public List<Employee> GetAll() { return _context.Employees.ToList(); }
        public bool Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
            return true;
        }
        public bool Update(Employee employee)
        {
            _context.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
        public Employee GetById(int id) { return _context.Employees.Find(id); }

        //changetracker: db setlerde değişmiş nesneleri yakalıyor ve state'ine göre değişikliği gerçekleştiriyor

    }
}
