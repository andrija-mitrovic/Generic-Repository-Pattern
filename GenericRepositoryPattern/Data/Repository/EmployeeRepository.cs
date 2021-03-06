﻿using GenericRepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Data.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Employee> GetEmployeesByFirstName()
        {
            return _context.Employees.OrderBy(p => p.FirstName).ToList();
        }
    }
}
