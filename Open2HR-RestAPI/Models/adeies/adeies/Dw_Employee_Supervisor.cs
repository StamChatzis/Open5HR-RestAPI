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
    [DataWindow("dw_employee_supervisor", DwStyle.Grid)]
    [Table("ots_adeies_employee_supervisor")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee_supervisor\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Dw_Employee_Supervisor
    {
        [Key]
        [DwColumn("ots_adeies_employee_supervisor", "id")]
        public decimal Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee_supervisor", "employee_id")]
        public decimal? Employee_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee_supervisor", "supervisor_id")]
        public decimal? Supervisor_Id { get; set; }

    }

}



