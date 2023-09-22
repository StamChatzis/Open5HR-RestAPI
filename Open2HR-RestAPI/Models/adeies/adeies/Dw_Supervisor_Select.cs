using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;
using System.Collections;

namespace Open2HRRestAPI.Models 
{
    [DataWindow("dw_supervisor_select", DwStyle.Default)]
    public class Dw_Supervisor_Select
    {
        [DwChild("Id", "Compute_1", typeof(Dddw_Supervisor_Names), AutoRetrieve = true)]
        [DwColumn("supervisor")]
        public double? Supervisor { get; set; }

    }

}



