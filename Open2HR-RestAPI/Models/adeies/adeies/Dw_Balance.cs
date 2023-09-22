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
    [DataWindow("dw_balance", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_leave_balance\" )  TABLE(NAME=\"ots_adeies_leave_category\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_leave_balance.leave_category_id\"    OP =\"=\"RIGHT=\"ots_adeies_leave_category.id\" )WHERE(    EXP1 =\"ots_adeies_leave_balance.employee_id\"   OP =\"=\"    EXP2 =\":an_id\" ) ) ARG(NAME = \"an_id\" TYPE = number)")]
    #endregion
    [DwParameter("an_id", typeof(double?))]
    public class Dw_Balance
    {
        [DwColumn("ots_adeies_leave_category", "title")]
        public string Ots_Adeies_Leave_Category_Title { get; set; }

        [DwColumn("ots_adeies_leave_balance", "days")]
        public decimal? Days { get; set; }

        [DwColumn("ots_adeies_leave_balance", "days_taken")]
        public decimal? Days_Taken { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("days - days_taken")]
        public object Compute_1 { get; set; }

    }

}



