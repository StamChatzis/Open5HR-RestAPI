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
    [DataWindow("dw_grid_adeies_ifistamenon", DwStyle.Grid)]
    [Table("ots_adeies_employee")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" )  TABLE(NAME=\"ots_adeies_employee_supervisor\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_employee.id\"    OP =\"=\"RIGHT=\"ots_adeies_employee_supervisor.employee_id\" )WHERE(    EXP1 =\"ots_adeies_employee_supervisor.supervisor_id\"   OP =\"=\"    EXP2 =\":an_ID\" ) ) ARG(NAME = \"an_ID\" TYPE = number)")]
    #endregion
    [DwParameter("an_ID", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Dw_Grid_Adeies_Ifistamenon
    {
        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "first_name")]
        public string Ots_Adeies_Employee_First_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "last_name")]
        public string Ots_Adeies_Employee_Last_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee", "email")]
        public string Ots_Adeies_Employee_Email { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee", "address")]
        public string Ots_Adeies_Employee_Address { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_employee", "address_num")]
        public decimal? Ots_Adeies_Employee_Address_Num { get; set; }

        [Key]
        [DwColumn("ots_adeies_employee", "id")]
        public decimal Ots_Adeies_Employee_Id { get; set; }

    }

}



