﻿using SalesWeb.Data;
using SalesWeb.Models;
using System.Collections.Generic;

namespace SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly SalesWebContext _context;

        public DepartmentService(SalesWebContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.ToList();
        }
    }
}
