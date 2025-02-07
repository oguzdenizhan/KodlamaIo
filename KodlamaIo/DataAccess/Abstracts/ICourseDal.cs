﻿using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Update(Course course);
        void Add(Course course);
        void Delete(Course course);
        List<Course> GetAll();
    }
}
