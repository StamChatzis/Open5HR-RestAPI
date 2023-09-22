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
    [DataWindow("dw_dddw_leaves_category", DwStyle.Grid)]
    [Table("ots_adeies_leave_category")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_leave_category\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dw_Dddw_Leaves_Category
    {
        [Key]
        [DwColumn("ots_adeies_leave_category", "id")]
        public decimal Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_leave_category", "title")]
        public string Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_leave_category", "default_balance")]
        public decimal? Default_Balance { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_leave_category", "is_default")]
        public byte? Is_Default { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("GetRow()")]
        public object Compute_1 { get; set; }

    }

}



