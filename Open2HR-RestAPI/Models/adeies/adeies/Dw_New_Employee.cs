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
    [DataWindow("dw_new_employee", DwStyle.Default)]
    [Table("ots_adeies_employee")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"ots_adeies_employee.id\"   OP =\"=\"    EXP2 =\":an_id\" ) ) ARG(NAME = \"an_id\" TYPE = number)")]
    #endregion
    [DwParameter("an_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Dw_New_Employee
    {
        [Key]
        [DwColumn("ots_adeies_employee", "id")]
        public decimal Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "first_name")]
        public string First_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "last_name")]
        public string Last_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "email")]
        public string Email { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee", "isSupervisor")]
        public int? Issupervisor { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee", "hire_date", TypeName = "datetime")]
        public DateTime? Hire_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee", "mobile_num")]
        public decimal? Mobile_Num { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee", "address")]
        public string Address { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee", "address_num")]
        public decimal? Address_Num { get; set; }

    }

}



