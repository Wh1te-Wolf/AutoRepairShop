﻿using AutoRepairShop.Entities;
using AutoRepairShop.Repository.BaseRepositories;
using AutoRepairShop.Repository.EF;
using AutoRepairShop.Repository.Interfaces;

namespace AutoRepairShop.Repository
{
    public class EmployeeRepository : BaseDictionaryRepository<Employee, AutoRepairShopContext>, IEmployeeRepository
    {

    }
}
