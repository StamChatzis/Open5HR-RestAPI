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
    [DataWindow("dw_category_select", DwStyle.Default)]
    public class Dw_Category_Select
    {
        [DwChild("Id", "Title", typeof(Dw_Dddw_Leaves_Category), AutoRetrieve = true)]
        [DwColumn("title")]
        public string Title { get; set; }

    }

}



