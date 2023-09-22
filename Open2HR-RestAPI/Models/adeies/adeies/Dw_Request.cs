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
    [DataWindow("dw_request", DwStyle.Default)]
    [Table("ots_adeies_leave_request")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_leave_request\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Dw_Request
    {
        [Key]
        [DwColumn("ots_adeies_leave_request", "id")]
        public decimal Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_leave_request", "employee_id")]
        public decimal? Employee_Id { get; set; }

        [ConcurrencyCheck]
        [Required(AllowEmptyStrings = true)]
        [DwChild("Id", "Title", typeof(Dw_Dddw_Leaves_Category), AutoRetrieve = true)]
        [DwColumn("ots_adeies_leave_request", "leave_category_id")]
        public decimal? Leave_Category_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_leave_request", "status_id")]
        public decimal? Status_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_leave_request", "duration")]
        public decimal? Duration { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_leave_request", "end_date", TypeName = "datetime")]
        public DateTime? End_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_leave_request", "start_date", TypeName = "datetime")]
        public DateTime? Start_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_leave_request", "sumbit_date", TypeName = "datetime")]
        public DateTime? Sumbit_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("DaysAfter(DateTime(start_date), DateTime(end_date))")]
        public object Compute_1 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Today()")]
        public object Compute_2 { get; set; }

    }

}



