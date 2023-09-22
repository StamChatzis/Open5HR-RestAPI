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
    [DataWindow("dw_dddw_leave_status", DwStyle.Grid)]
    [Table("ots_adeies_status")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_status\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dw_Dddw_Leave_Status
    {
        [Key]
        [DwColumn("ots_adeies_status", "id")]
        public decimal Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_status", "state")]
        public string State { get; set; }

    }

}



