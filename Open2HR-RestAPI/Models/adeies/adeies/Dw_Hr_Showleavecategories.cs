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
    [DataWindow("dw_hr_showleavecategories", DwStyle.Grid)]
    [Table("ots_adeies_leave_category")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_leave_category\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ots_adeies_leave_category\\\".\\\"isActive\\\"\"   OP =\">\"    EXP2 =\"0\" ) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Dw_Hr_Showleavecategories
    {
        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_leave_category", "title")]
        public string Title { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_leave_category", "default_balance")]
        public decimal? Default_Balance { get; set; }

        [Key]
        [DwColumn("ots_adeies_leave_category", "id")]
        public decimal Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_leave_category", "is_default")]
        public byte? Is_Default { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_leave_category", "isActive")]
        public byte? Isactive { get; set; }

    }

}



