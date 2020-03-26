using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Project.Model
{
    public class TaskSparepart
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int SparepartId { get; set; }
        public Sparepart Sparepart { get; set; }

        public int Quantity { get; set; }

    }
}
