using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Controller
{
    public class BatchController
    {
        Batch studentBatch;
        public Boolean saveBatch(string batchNumber, string term)
        {
            studentBatch = new Batch(batchNumber, term);
            return studentBatch.create();
        }

        public static Batch[] all()
        {
            return Batch.getAll();
        }
    }
}
