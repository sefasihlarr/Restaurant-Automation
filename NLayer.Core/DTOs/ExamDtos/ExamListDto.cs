﻿using NLayer.Core.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs.ExamDtos
{
    public class ExamListDto
    {
        public List<Exam> Exams { get; set; }
        public List<Scors> Scors { get; set; }
    }
}