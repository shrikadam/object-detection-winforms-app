using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace MLNET_WinForms.Models
{
    class ImgPredictions
    {
        [ColumnName("776")]
        public float[] ImgType { get; set; }
    }
}
