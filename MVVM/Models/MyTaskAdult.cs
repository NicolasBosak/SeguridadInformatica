﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguridadInformatica.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class MyTaskAdult
    {
        public string TaskName { get; set; }
        public bool Completed { get; set; }
        public int CategoryId { get; set; }
        public string TaskColor { get; set; }
    }
}
